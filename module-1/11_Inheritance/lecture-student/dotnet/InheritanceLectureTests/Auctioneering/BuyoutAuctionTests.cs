using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace InheritanceLecture.Auctioneering.Tests
{
    [TestClass()]
    public class BuyoutAuctionTests
    {
        private static readonly Type typeBuyoutAuction = SafeReflection.GetType("BuyoutAuction", "InheritanceLecture.Auctioneering");

        [TestMethod]
        public void BidsMadeAfterBuyoutPriceMetAreIgnored()
        {
            object theAuction = SafeReflection.CreateInstance(typeBuyoutAuction, new object[] { 100 });
            Assert.IsNotNull(theAuction);

            SafeReflection.InvokeMethod(theAuction, "PlaceBid", new object[] { new Bid("Buyout Bob", 100) });
            SafeReflection.InvokeMethod(theAuction, "PlaceBid", new object[] { new Bid("Too Late Tom", 101) });

            object allBids = SafeReflection.GetPropertyValue(theAuction, "AllBids");
            object currentHighBid = SafeReflection.GetPropertyValue(theAuction, "CurrentHighBid");

            Assert.AreEqual(1, ((Bid[])allBids).Length);
            Assert.AreEqual("Buyout Bob", ((Bid)currentHighBid).Bidder);
            Assert.AreEqual(100, ((Bid)currentHighBid).BidAmount);
        }

        [TestMethod]
        public void BidsGreaterThanBuyoutPriceAreReducedToBuyoutPrice()
        {
            object theAuction = SafeReflection.CreateInstance(typeBuyoutAuction, new object[] { 100 });
            Assert.IsNotNull(theAuction);

            SafeReflection.InvokeMethod(theAuction, "PlaceBid", new object[] { new Bid("Big Spender", 200) });

            object currentHighBid = SafeReflection.GetPropertyValue(theAuction, "CurrentHighBid");

            Assert.AreEqual("Big Spender", ((Bid)currentHighBid).Bidder);
            Assert.AreEqual(100, ((Bid)currentHighBid).BidAmount);
        }
    }
}