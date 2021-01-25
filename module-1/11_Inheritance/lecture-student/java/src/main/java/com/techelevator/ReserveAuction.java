package com.techelevator;

public class ReserveAuction extends Auction {

    private final int reservePrice;

    public ReserveAuction(String itemForSale, int reservePrice) {
        super(itemForSale); //call the superclass' constructor (super();) and pass it whatever item for sale was passed through this one
        this.reservePrice = reservePrice;
    }

    public int getReservePrice() {
        return reservePrice;
    }

    @Override //we are annotating that this method is overriding a method from a superclass
    public boolean placeBid(Bid offeredBid) { //this is overriding a method
//        return super.placeBid(offeredBid); (this doesn't override it at all, it's just calling the superclass method)

        boolean isWinningBid = false;

        if(offeredBid.getBidAmount() >= reservePrice) {
            isWinningBid = super.placeBid(offeredBid);
        }

        return isWinningBid;
    }

}
