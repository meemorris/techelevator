using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace InheritanceLecture.Auctioneering.Tests
{
    [TestClass()]
    public class ReserveAuctionTests
    {
        private static readonly Type typeReserveAuction = SafeReflection.GetType("ReserveAuction", "InheritanceLecture.Auctioneering");

        [TestMethod]
        public void BidIsIgnoredIfLessThanReserve()
        {
            object theAuction = SafeReflection.CreateInstance(typeReserveAuction, new object[] { 100 });
            Assert.IsNotNull(theAuction);

            SafeReflection.InvokeMethod(theAuction, "PlaceBid", new object[] { new Bid("Cheapskate", 99) });

            object allBids = SafeReflection.GetPropertyValue(theAuction, "AllBids");

            Assert.AreEqual(0, ((Bid[])allBids).Length);
        }

        [TestMethod]
        public void BidIsAcceptedIfBidIsEqualToReserve()
        {
            object theAuction = SafeReflection.CreateInstance(typeReserveAuction, new object[] { 100 });
            Assert.IsNotNull(theAuction);

            SafeReflection.InvokeMethod(theAuction, "PlaceBid", new object[] { new Bid("Bidder Bob", 100) });

            object currentHighBid = SafeReflection.GetPropertyValue(theAuction, "CurrentHighBid");

            Assert.IsTrue(currentHighBid.GetType() == typeof(Bid));
            Assert.AreEqual("Bidder Bob", ((Bid)currentHighBid).Bidder);
            Assert.AreEqual(100, ((Bid)currentHighBid).BidAmount);
        }
    }
}