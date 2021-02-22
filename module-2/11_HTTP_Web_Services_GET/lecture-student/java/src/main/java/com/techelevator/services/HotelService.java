package com.techelevator.services;

import com.techelevator.models.City;
import com.techelevator.models.Hotel;
import com.techelevator.models.Review;
import org.springframework.web.client.RestTemplate;

public class HotelService {

    private final String API_BASE_URL;
    private RestTemplate restTemplate = new RestTemplate(); //make HTTP requests and deserialize the data into an object. Serialize it means make it a big string

    public HotelService(String apiURL) {
        API_BASE_URL = apiURL;
    }

    public Hotel[] listHotels() {
       //call the api to get the list of hotels, getForObject(path to resource/api call, what I expect back)
        return restTemplate.getForObject(API_BASE_URL + "hotels", Hotel[].class); //this is how to convert from a string representation into an object that I want stored in memory
    }

    public Review[] listReviews() {
        return restTemplate.getForObject(API_BASE_URL + "reviews", Review[].class);
    }

    public Hotel getHotelById(int id) {
        return restTemplate.getForObject(API_BASE_URL + "hotels/" + id, Hotel.class);
    }

    public Review[] getReviewsByHotelId(int hotelID) {
        return restTemplate.getForObject(API_BASE_URL + "hotels/" + hotelID + "/reviews", Review[].class);
    }

    public Hotel[] getHotelsByStarRating(int stars) {
        return restTemplate.getForObject(API_BASE_URL + "hotels?stars=" + stars, Hotel[].class);
    }

    //little bit bad form because this query is in the HotelService class when it is not calling the hotel service API. Should be in its own service: CityService, etc.

    public City getWithCustomQuery(){
        return restTemplate.getForObject("https://api.teleport.org/api/cities/geonameid%3A5128581/", City.class);
    }

}
