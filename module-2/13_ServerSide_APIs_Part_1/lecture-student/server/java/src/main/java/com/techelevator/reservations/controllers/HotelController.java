package com.techelevator.reservations.controllers;

import com.techelevator.reservations.dao.HotelDAO;
import com.techelevator.reservations.dao.MemoryHotelDAO;
import com.techelevator.reservations.dao.MemoryReservationDAO;
import com.techelevator.reservations.dao.ReservationDAO;
import com.techelevator.reservations.models.Hotel;
import com.techelevator.reservations.models.Reservation;
import org.springframework.web.bind.annotation.*;

import java.util.List;

//default server for TomCat could be loalhost8080

@RestController //tells Spring Boot this will handle stuff
public class HotelController {

    private HotelDAO hotelDAO;
    private ReservationDAO reservationDAO;

    public HotelController() { //the framework instantiates a new controller every time we have a request coming in
        this.hotelDAO = new MemoryHotelDAO(); //this calls the constructors and instantiates them
        this.reservationDAO = new MemoryReservationDAO(hotelDAO); //instantiating DAOs here
    }

    /**
     * Return All Hotels
     *
     * @return a list of all hotels in the system
     */
    @RequestMapping(path = "/hotels", method = RequestMethod.GET) //This request mapping says when a request comes in for this URL, I got it. You do want to make sure you specify both
    public List<Hotel> list() {
        return hotelDAO.list();
    }

    /**
     * Return hotel information
     *
     * @param id the id of the hotel
     * @return all info for a given hotel
     */
    @RequestMapping(path = "/hotels/{id}", method = RequestMethod.GET) //path variable goes in the curly braces
    public Hotel get(@PathVariable int id) { //order is not important, just impt that it matches, any number of parameters allowed
        return hotelDAO.get(id);
    } //hey look for this path variable in the path that they sent in
//Spring Framework automatically does the conversion to int for us

    //List all of the reservations

   // @return a list of all reservations in the system

    @RequestMapping(path = "/reservations", method = RequestMethod.GET)
    public List<Reservation> getReservations() {
        return reservationDAO.findAll(); //I'm going to go get this data from the model and return it back
    }

    //Get reservation by id
    //path: /reservation/{id}
    //request method: GET
    //return: reservation info for a given id using path variable

    @RequestMapping(path = "/reservation/{id}", method = RequestMethod.GET)
    public Reservation getReservationById(@PathVariable int id) {
        return reservationDAO.get(id);
    }

    /*
    List all reservations by hotel
    path: /hotels/{id}/reservations
    request method: GET
    return: list of all reservations in the system
     */

    @RequestMapping(path = "/hotels/{id}/reservations", method = RequestMethod.GET)
    public List<Reservation> getReservationsForHotel(@PathVariable int id) {
        return reservationDAO.findByHotel(id); //passing in the id as the hotel id
    }

    /*
    add reservation
    path: /hotels/{id}/reservations
    request method: POST
    add a new reservation to the given hotel based on the request body
     */

    @RequestMapping(path ="/hotels/{id}/reservations", method = RequestMethod.POST)
    public Reservation addReservation(@PathVariable int id, @RequestBody Reservation reservation) { //look in the request body and there should be a reservation
        return reservationDAO.create(reservation, id);
    }

    /*
    Filter hotels by city and state, city will be optional
    path: /hotels/filter?state={state}&city={city}
    request method: GET
     */

    @RequestMapping(path="/filter", method = RequestMethod.GET)
    public List<Hotel> filterByCityAndState(@RequestParam String state, @RequestParam(required = false) String city) { //requestParam is the annotation for a query string parameter
        //if city is populated, use that, otherwise use state
        if (city != null) {
            return hotelDAO.filterByCity(city);
        } else {
            return hotelDAO.filterByState(state); //controller should be dumb and let the model handle the business logic
        }
    }


}
