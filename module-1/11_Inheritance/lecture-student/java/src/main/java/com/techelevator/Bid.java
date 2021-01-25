package com.techelevator;

import java.math.BigDecimal;

public class Bid {

	private final String bidder;
	private final BigDecimal bidAmount;

	public Bid(String bidder, int bidAmount) {
		this.bidder = bidder;
		this.bidAmount = BigDecimal.valueOf(bidAmount); //boxed into a big decimal
	}

	public String getBidder() {
		return bidder;
	}

	public int getBidAmount() {
		return bidAmount.intValue();
	} //this turns it back into a int value, all encapsulated inside the bid
}
