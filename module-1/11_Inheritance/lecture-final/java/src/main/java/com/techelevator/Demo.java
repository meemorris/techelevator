package com.techelevator;

public class Demo {

    public static void main(String[] args) {

        Auction firstAuction = new Auction("Shoes");
        System.out.println("High bid for the shoes is: " + firstAuction.getHighBid().getBidAmount());
        firstAuction.placeBid(new Bid("Jaclyn", 5));
        System.out.println("High bid for the shoes is: " + firstAuction.getHighBid().getBidAmount());
        System.out.println("The winning bidder is currently: " + firstAuction.getHighBid().getBidder());
        firstAuction.placeBid(new Bid("Jamal", 6));
        firstAuction.placeBid(new Bid("Dom", 10));
        firstAuction.placeBid(new Bid("David", 7));
        System.out.println("High bid for the shoes is: " + firstAuction.getHighBid().getBidAmount());
        System.out.println("The winning bidder is currently: " + firstAuction.getHighBid().getBidder());

        ReserveAuction secondAuction = new ReserveAuction("Pens", 80);
        secondAuction.placeBid(new Bid("Jonathan", 75));
        secondAuction.placeBid(new Bid("Zac", 85));
        System.out.println("The winning bidder is currently: " + secondAuction.getHighBid().getBidder());

        BuyoutAuction thirdAuction = new BuyoutAuction("Time Machines (Lot of 12)", 450);
        thirdAuction.placeBid(new Bid("Dan", 300));
        System.out.println("The winning bidder is currently: " + thirdAuction.getHighBid().getBidder());
        thirdAuction.placeBid(new Bid("Jason", 450));
        thirdAuction.placeBid(new Bid("Connor", 500));
        System.out.println("The winning bidder is currently: " + thirdAuction.getHighBid().getBidder());




    }
}
