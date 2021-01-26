package com.techelevator;

public class ReserveAuction extends Auction {

    private final int reservePrice;

    public ReserveAuction(String itemForSale, int reservePrice) {
        super(itemForSale);
        this.reservePrice = reservePrice;
    }

    public int getReservePrice() {
        return reservePrice;
    }

    @Override
    public boolean placeBid(Bid offeredBid) {
        boolean isWinningBid = false;

        if (offeredBid.getBidAmount() >= reservePrice) {
            isWinningBid = super.placeBid(offeredBid);
        }

        return isWinningBid;
    }


}
