package com.techelevator.countrylanguage;

import org.junit.*;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.jdbc.datasource.SingleConnectionDataSource;

import java.sql.SQLException;
import java.util.List;

public class JDBCCountryLanguageDAOIntegrationTests {


    private static final String TEST_COUNTRY = "XYZ";

    /* Using this particular implementation of DataSource so that
     * every database interaction is part of the same database
     * session and hence the same database transaction */
    private static SingleConnectionDataSource dataSource; //we don't want to do connection pooling here
    private JDBCCountryLanguageDAO dao;

    /* Before any tests are run, this method initializes the datasource for testing. */
    @BeforeClass //this is in scope everywhere in this class
    public static void setupDataSource() {
        dataSource = new SingleConnectionDataSource(); //instantiating the object here
        dataSource.setUrl("jdbc:postgresql://localhost:5432/world");
        dataSource.setUsername("postgres");
        dataSource.setPassword("postgres1");
        /* The following line disables autocommit for connections
         * returned by this DataSource. This allows us to rollback
         * any changes after each test */
        dataSource.setAutoCommit(false); //extremely important, if someone stops our program midway, ensures we don't autocommit, allows us to rollback
        //safest way to do things would be to blow away all the data. Recreate all the test data. Instead of using delete from, Truncate just blows it away, doesn't do any logging
        //cascading delete is a bit slower than truncate
    }

    /* After all tests have finished running, this method will close the DataSource */
    @AfterClass
    public static void closeDataSource() throws SQLException {
        dataSource.destroy();
    }

    @Before //this is saying run this before every test
    public void setup() {
        String sqlInsertCountry = "INSERT INTO country (code, name, continent, region, surfacearea, indepyear, population, "
                +"lifeexpectancy, gnp, gnpold, localname, governmentform, headofstate, capital, code2) VALUES (?, 'Afghanistan', " +
                "'Asia', 'Southern and Central Asia', 652090, 1919, 22720000, 45.9000015, 5976.00, NULL, 'Afganistan/Afqanestan', " +
                "'Islamic Emirate', 'Mohammad Omar', 1, 'AF')";
        JdbcTemplate jdbcTemplate = new JdbcTemplate(dataSource); //create jdbctemplate with same datasource that is not autocommiting
        jdbcTemplate.update(sqlInsertCountry, TEST_COUNTRY); //update statement, inserting Test_country (static final string XYZ)
        dao = new JDBCCountryLanguageDAO(dataSource); //WHAT IS THIS
    }

    /* After each test, we rollback any changes that were made to the database so that
     * everything is clean for the next test */
    @After
    public void rollback() throws SQLException { //WHY DOES IT THROW a SQL Exception
        dataSource.getConnection().rollback();
    }

    @Test
    public void test_get_languages_for_country() {
        //arrange
        //add a country language to the database
        addLanguageForCountryToDatabase(TEST_COUNTRY, 5.5, "Klingon", true);
        CountryLanguage expected = new CountryLanguage(TEST_COUNTRY, true, "Klingon", 5.5);

        //act
        List<CountryLanguage> list = dao.getLanguagesForCountry(TEST_COUNTRY);
        //assert
        Assert.assertEquals(1, list.size());
        assertLanguagesAreEqual(expected, list.get(0));
    }

    private void addLanguageForCountryToDatabase(String countryCode, double percentage, String name, boolean isOfficial) {
        String sql = "INSERT INTO countrylanguage(countrycode, percentage, isOfficial, language) VAlUES(?,?,?,?)";
        JdbcTemplate jdbcTemplate = new JdbcTemplate(dataSource); //create jdbctemplate with same datasource that is not autocommiting
        jdbcTemplate.update(sql,countryCode, percentage, isOfficial, name); //update statement, inserting Test_country (static final string XYZ)
    }

    private void assertLanguagesAreEqual(CountryLanguage a, CountryLanguage b) {
        Assert.assertEquals(a.getCountryCode(), b.getCountryCode());
        Assert.assertEquals(a.getLanguage(), b.getLanguage());
        Assert.assertEquals(a.isOfficial(), b.isOfficial());
        Assert.assertEquals(a.getPercentage(), b.getPercentage(), .01);
    }

}
