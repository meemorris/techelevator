package com.techelevator;

public class BuyoutAuction extends Auction {

    private final int buyoutPrice;

    public BuyoutAuction(String itemForSale, int buyoutPrice) {
        super(itemForSale);
        this.buyoutPrice = buyoutPrice;
    }

    public boolean isAuctionOver() {
        Bid winningBid = super.getHighBid();
        return winningBid.getBidAmount() >= buyoutPrice;
    }

    @Override
    public boolean placeBid(Bid offeredBid) {
        boolean isWinner = false;
        if (!isAuctionOver()) {
            isWinner = super.placeBid(offeredBid);
        }
        return isWinner;
    }
}
