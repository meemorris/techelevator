package com.techelevator.city;

import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertNotEquals;
import static org.junit.Assert.assertNotNull;

import java.sql.SQLException;
import java.util.List;

import org.junit.*;
import org.junit.runners.MethodSorters;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.jdbc.datasource.SingleConnectionDataSource;

@FixMethodOrder(MethodSorters.NAME_ASCENDING)
public class JDBCCityDAOIntegrationTest {

	private static final String TEST_COUNTRY = "XYZ";

	/* Using this particular implementation of DataSource so that
	 * every database interaction is part of the same database
	 * session and hence the same database transaction */
	private static SingleConnectionDataSource dataSource; //we don't want to do connection pooling here
	private JDBCCityDAO dao;

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
		dao = new JDBCCityDAO(dataSource); //WHAT IS THIS
	}

	/* After each test, we rollback any changes that were made to the database so that
	 * everything is clean for the next test */
	@After
	public void rollback() throws SQLException { //WHY DOES IT THROW a SQL Exception
		dataSource.getConnection().rollback();
	}

	@Test
	public void save_new_city_and_read_it_back() throws SQLException { //if you're actually executing some SQL, then you need this SQLException, this line should have been deleted
		City theCity = makeLocalCityObject("SQL Station", "South Dakota", TEST_COUNTRY, 65535);

		dao.create(theCity);
		City savedCity = dao.findCityById(theCity.getId()); //some people say you can't use your dao to test your dao. Can't assume your dao works in order to test your dao

		assertNotEquals(null, theCity.getId()); //need to make sure that id is set in the dao class
		assertCitiesAreEqual(theCity, savedCity); //method at the end, making sure theCity at the end is the same as theCity created
	}

	@Test
	public void returns_cities_by_country_code() {
		City theCity = makeLocalCityObject("SQL Station", "South Dakota", TEST_COUNTRY, 65535); //in memory for your application

		dao.create(theCity); //creates it in the database. we're trying to test findCityByCountryCode, we're assuming this worked
		List<City> results = dao.findCityByCountryCode(TEST_COUNTRY);

		assertNotNull(results);
		assertEquals(1, results.size()); //we just created this one city
		City savedCity = results.get(0); //there is only one item in the list
		assertCitiesAreEqual(theCity, savedCity);
	}

	@Test
	public void returns_multiple_cities_by_country_code() {

		dao.create(makeLocalCityObject("SQL Station", "South Dakota", TEST_COUNTRY, 65535)); //Arrange
		dao.create(makeLocalCityObject("Postgres Point", "North Dakota", TEST_COUNTRY, 65535));

		List<City> results = dao.findCityByCountryCode(TEST_COUNTRY); //Act

		assertNotNull(results);
		assertEquals(2, results.size()); //making sure it can return more than one, already checked that the values come back correctly above
	}

	@Test
	public void returns_cities_by_district() {
		String testDistrict = "Tech Elevator"; //assuming there isn't already a Tech Elevator, so we are still a little dependent on the data
		City theCity = makeLocalCityObject("SQL Station", testDistrict, TEST_COUNTRY, 65535);
		dao.create(theCity); //adding it to the database

		List<City> results = dao.findCityByDistrict(testDistrict);//act

		assertNotNull(results); //if it is null, we want this to be a failure not an exception, we want the rest of our tests to run
		assertEquals(1, results.size());
		City savedCity = results.get(0);
		assertCitiesAreEqual(theCity, savedCity);
	}

	@Test
	public void update_city_bad_test_always_passes() {
		City theCity = makeLocalCityObject("SQL Station", "South Dakota", TEST_COUNTRY, 65535);
		//add the city to the database
		dao.create(theCity);

		//update the local object
		theCity.setPopulation(1);
		theCity.setDistrict("Disneyland");

		//save to the database
		City updatedCity = dao.update(theCity); //testing the return value of this update rather than rereading it from the database. BAD TEST. Still passes even when you don't update anything.
		//this is bumping up a java object against a java object

		//check that they are the same
		assertCitiesAreEqual(theCity, updatedCity);
	}

	@Test
	public void update_city_good_test() {
		City theCity = makeLocalCityObject("SQL Station", "South Dakota", TEST_COUNTRY, 65535);
		//add the city to the database
		dao.create(theCity);

		//update the local object
		theCity.setPopulation(1);
		theCity.setDistrict("Disneyland");

		//save to the database
		City updateResult = dao.update(theCity); //IS THIS NECESSARY OR WHY IS THIS

		//re-read the city from the database
		City updatedCity = dao.findCityById(theCity.getId());

		//check that they are the same
		assertCitiesAreEqual(theCity, updatedCity);
	}

	@Test
	public void save_new_city_and_delete() {
		//Arrange - make new city in Java, then create it in SQL db
		City theCity = makeLocalCityObject("SQL Station", "South Dakota", TEST_COUNTRY, 65535);

		dao.create(theCity);

		//Act - get new City's ID from SQL, then delete it
		long newId = theCity.getId();
		dao.delete(newId);

		//Assert - assert that there will be no result when we query the SQL db by the city's ID
		Assert.assertNull(dao.findCityById(newId));
	}



	private City makeLocalCityObject(String name, String district, String countryCode, int population) {
		City theCity = new City();
		theCity.setName(name);
		theCity.setDistrict(district);
		theCity.setCountryCode(countryCode);
		theCity.setPopulation(population);
		return theCity;
	}

	private void assertCitiesAreEqual(City expected, City actual) {
		assertEquals(expected.getId(), actual.getId());
		assertEquals(expected.getName(), actual.getName());
		assertEquals(expected.getDistrict(), actual.getDistrict());
		assertEquals(expected.getCountryCode(), actual.getCountryCode());
		assertEquals(expected.getPopulation(), actual.getPopulation());
	}
}
