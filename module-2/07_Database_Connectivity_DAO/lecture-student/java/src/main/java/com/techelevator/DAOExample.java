package com.techelevator;

import org.apache.commons.dbcp2.BasicDataSource;

import com.techelevator.city.City;
import com.techelevator.city.CityDAO;
import com.techelevator.city.JDBCCityDAO;

import java.util.List;

public class DAOExample {

	public static void main(String[] args) {
	
		BasicDataSource worldDataSource = new BasicDataSource();
		worldDataSource.setUrl("jdbc:postgresql://localhost:5432/world");
		worldDataSource.setUsername("postgres");
		worldDataSource.setPassword("postgres1");
		
		CityDAO dao = new JDBCCityDAO(worldDataSource); //interact with the database using this, JDBCCityDAO object works due to polymorphism

		
		City smallville = new City(); //22-25 makes changes to the city object in memory
		smallville.setCountryCode("USA");
		smallville.setDistrict("KS");
		smallville.setName("Smallville");
		smallville.setPopulation(42080);
		
		dao.create(smallville); //this is where you make changes to the database
		
		City theCity = dao.findCityById(smallville.getId());
		List<City> allTheCities = dao.findCityByCountryCode("USA");
		for(City c : allTheCities) {
			System.out.println(c.getName() + " " + c.getPopulation());
		}


		allTheCities = dao.findCityByDistrict("Ohio");
		for(City c : allTheCities) {
			System.out.println(c.getName() + " " + c.getPopulation());
		}

		//change all of the cities in ohio to be in oz
		for(City c : allTheCities) {
			c.setDistrict("Oz"); //this modifies memory
			dao.update(c); //this saves the change to the database
		}

		//delete smallville aka theCity
		dao.delete(theCity.getId()); //deletes it out of the database
	}

}
