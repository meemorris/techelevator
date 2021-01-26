package com.techelevator;

import java.math.BigDecimal;

public class Bid {

	private final String bidder;
	private final BigDecimal bidAmount;

	public Bid(String bidder, int bidAmount) {
		this.bidder = bidder;
		this.bidAmount = BigDecimal.valueOf(bidAmount);
	}

	public String getBidder() {
		return bidder;
	}

	public int getBidAmount() {
		return bidAmount.intValue();
	}
}
