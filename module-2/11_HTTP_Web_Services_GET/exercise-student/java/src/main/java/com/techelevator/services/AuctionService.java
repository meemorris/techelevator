package com.techelevator.services;

import org.springframework.web.client.ResourceAccessException;
import org.springframework.web.client.RestClientResponseException;
import org.springframework.web.client.RestTemplate;

import com.techelevator.models.Auction;

public class AuctionService {

    public static final String BASE_URL = "http://localhost:3000/auctions";
    public RestTemplate restTemplate = new RestTemplate();
    private final ConsoleService console = new ConsoleService();


    public Auction[] listAllAuctions() {
        return restTemplate.getForObject(BASE_URL, Auction[].class);
    }

    public Auction listDetailsForAuction(int id) {
        return restTemplate.getForObject(BASE_URL + "/" + id, Auction.class);
    }

    public Auction[] findAuctionsSearchTitle(String title) {
        Auction[] auctions;
        if (title != null) {
            auctions = restTemplate.getForObject(BASE_URL + "?title_like=" + title, Auction[].class);
        } else {
            auctions = null;
        }
        return auctions;
    }

    public Auction[] findAuctionsSearchPrice(double price) {
        Auction[] auctions;
        try {
            auctions = restTemplate.getForObject(BASE_URL + "?currentBid_lte=" + price, Auction[].class);
        } catch (Exception e) {
            auctions = null;
            System.out.println("Search was not valid.");
        }
        return auctions;
    }

}
