package com.techelevator;

public class BuyoutAction extends Auction {
    private final int buyoutPrice;

    public BuyoutAction(String itemForSale, int buyoutPrice) {
        super(itemForSale);
        this.buyoutPrice = buyoutPrice;
    }

    public boolean isAuctionOver() { //this is a new method (doesn't need an override, we are not using a method from the superclass)
        Bid winningBid = super.getHighBid();
        return winningBid.getBidAmount() >= buyoutPrice;
    }

    @Override
    public boolean placeBid(Bid offeredBid) {
        boolean isWinner = false;
        if (!isAuctionOver()) { //taking bids only if auction isn't over
            isWinner = super.placeBid(offeredBid);
        }
        return isWinner;
    }
}
