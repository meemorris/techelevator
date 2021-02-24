package com.techelevator.countrylanguage;

import com.techelevator.city.City;
import org.apache.commons.dbcp2.BasicDataSource;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.jdbc.support.rowset.SqlRowSet;

import javax.sql.DataSource;
import java.util.ArrayList;
import java.util.List;

public class JDBCCountryLanguageDAO {

    private JdbcTemplate jdbcTemplate;


    public JDBCCountryLanguageDAO(DataSource dataSource) {
        jdbcTemplate = new JdbcTemplate(dataSource);
    }

    public List<CountryLanguage> getLanguagesForCountry(String countryCode) {
        ArrayList<CountryLanguage> list = new ArrayList<>();
        String sqlFindCityByCountryCode = "SELECT countrycode, language, isOfficial, percentage " + "FROM countrylanguage "
                + "WHERE countrycode = ?";
        SqlRowSet results = jdbcTemplate.queryForRowSet(sqlFindCityByCountryCode, countryCode);
        while (results.next()) {
            CountryLanguage theCountryLanguage = mapRowToCity(results);
            list.add(theCountryLanguage);
        }
        return list;
    }


}
