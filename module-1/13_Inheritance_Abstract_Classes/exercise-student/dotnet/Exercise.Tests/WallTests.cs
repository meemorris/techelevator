using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercise.Tests
{
    [TestClass]
    public class WallTests
    {
        private static readonly Type typeWall = SafeReflection.GetType("Wall", "Exercise");

        [TestMethod]
        public void ClassExists()
        {
            Assert.IsTrue(typeWall != null);
        }

        [TestMethod]
        public void ConstructorHasTheProperties()
        {
            Assert.IsTrue(SafeReflection.HasConstructor(typeWall, new Type[] { typeof(string), typeof(string) }));
        }

        [TestMethod]
        public void HasGetAreaMethod()
        {
            Assert.IsTrue(SafeReflection.HasMethod(typeWall, "GetArea"));
        }
    }
}
