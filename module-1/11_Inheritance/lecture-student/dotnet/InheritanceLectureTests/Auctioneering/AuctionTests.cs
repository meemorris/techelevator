using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InheritanceLecture.Auctioneering.Tests
{
    [TestClass()]
    public class AuctionTests
    {
        [TestMethod]
        public void HighBidStartsAtZero()
        {
            Auction theAuction = new Auction();
            Assert.AreEqual(0, theAuction.CurrentHighBid.BidAmount);
        }

        [TestMethod]
        public void KeepsTrackOfHighBid()
        {
            Auction theAuction = new Auction();
            theAuction.PlaceBid(new Bid("Kermit", 100));
            theAuction.PlaceBid(new Bid("Miss Piggy", 150));
            theAuction.PlaceBid(new Bid("Fozzie", 125));

            Assert.AreEqual("Miss Piggy", theAuction.CurrentHighBid.Bidder);
            Assert.AreEqual(150, theAuction.CurrentHighBid.BidAmount);
        }

        [TestMethod]
        public void ReturnsAllBidsInOrderPlaced()
        {
            Auction theAuction = new Auction();
            theAuction.PlaceBid(new Bid("Kermit", 100));
            theAuction.PlaceBid(new Bid("Miss Piggy", 150));
            theAuction.PlaceBid(new Bid("Fozzie", 125));

            Bid[] bids = theAuction.AllBids;

            Assert.AreEqual(3, bids.Length);
            Assert.AreEqual("Kermit", bids[0].Bidder);
            Assert.AreEqual(100, bids[0].BidAmount);
            Assert.AreEqual("Miss Piggy", bids[1].Bidder);
            Assert.AreEqual(150, bids[1].BidAmount);
            Assert.AreEqual("Fozzie", bids[2].Bidder);
            Assert.AreEqual(125, bids[2].BidAmount);
        }

        [TestMethod]
        public void FirstBidPlacedWinsInCaseOfTie()
        {
            Auction theAuction = new Auction();
            theAuction.PlaceBid(new Bid("Kermit", 100));
            theAuction.PlaceBid(new Bid("Miss Piggy", 100));
            Assert.AreEqual("Kermit", theAuction.CurrentHighBid.Bidder);
            Assert.AreEqual(100, theAuction.CurrentHighBid.BidAmount);
        }
    }
}
