using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercise.Tests
{
    [TestClass]
    public class TriangleWallTests
    {
        private static readonly Type typeTriangle = SafeReflection.GetType("TriangleWall", "Exercise");
        private static readonly Type typeWall = SafeReflection.GetType("Wall", "Exercise");

        [TestMethod]
        public void ConstructorSetsTheValues()
        {
            object subject = SafeReflection.CreateInstance(typeTriangle, new object[] { "TEST", "TESTCOLOR", 1, 2 });

            object subjectName = SafeReflection.GetPropertyValue(subject, "Name");
            object subjectColor = SafeReflection.GetPropertyValue(subject, "Color");
            object subjectBase = SafeReflection.GetPropertyValue(subject, "Base");
            object subjectHeight = SafeReflection.GetPropertyValue(subject, "Height");

            Assert.IsNotNull(subject);
            Assert.AreEqual("TEST", subjectName);
            Assert.AreEqual("TESTCOLOR", subjectColor);
            Assert.AreEqual(1, subjectBase);
            Assert.AreEqual(2, subjectHeight);
        }

        [TestMethod]
        public void ItIsAWall()
        {
            object subject = SafeReflection.CreateInstance(typeTriangle, new object[] { "TEST", "TESTCOLOR", 1, 2 });
            Assert.IsInstanceOfType(subject, typeWall);
        }

        [TestMethod]
        public void GetAreaCalculatesCorrectArea()
        {
            object subject = SafeReflection.CreateInstance(typeTriangle, new object[] { "TEST", "TESTCOLOR", 2, 3 });
            object area = SafeReflection.InvokeMethod(subject, "GetArea", null);
            Assert.AreEqual(3, area);
        }

        [TestMethod]
        public void GetAreaRoundsDown()
        {
            object subject = SafeReflection.CreateInstance(typeTriangle, new object[] { "TEST", "TESTCOLOR", 3, 3 });
            object area = SafeReflection.InvokeMethod(subject, "GetArea", null);
            Assert.AreEqual(4, area);
        }

        [TestMethod]
        public void ToStringReturnsTheFormattedString()
        {
            object subject = SafeReflection.CreateInstance(typeTriangle, new object[] { "TEST", "TESTCOLOR", 1, 3 });
            Assert.AreEqual("TEST (1x3) triangle", subject.ToString());
        }
    }
}