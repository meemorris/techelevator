using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercise.Tests
{
    [TestClass]
    public class SquareWallTests
    {
        private static readonly Type typeSquare = SafeReflection.GetType("SquareWall", "Exercise");
        private static readonly Type typeRectangle = SafeReflection.GetType("RectangleWall", "Exercise");
        private static readonly Type typeWall = SafeReflection.GetType("Wall", "Exercise");

        [TestMethod]
        public void ConstructorSetsTheProperties()
        {
            object subject = SafeReflection.CreateInstance(typeSquare, new object[] { "TEST", "TESTCOLOR", 23 });
            Assert.IsNotNull(subject);

            object subjectName = SafeReflection.GetPropertyValue(subject, "Name");
            object subjectColor = SafeReflection.GetPropertyValue(subject, "Color");
            object subjectLength = SafeReflection.GetPropertyValue(subject, "Length");
            object subjectHeight = SafeReflection.GetPropertyValue(subject, "Height");

            Assert.AreEqual("TEST", subjectName);
            Assert.AreEqual("TESTCOLOR", subjectColor);
            Assert.AreEqual(23, subjectLength);
            Assert.AreEqual(23, subjectHeight);
        }

        [TestMethod]
        public void ItIsAWall()
        {
            object subject = SafeReflection.CreateInstance(typeSquare, new object[] { "TEST", "TESTCOLOR", 1 });
            Assert.IsInstanceOfType(subject, typeWall);
        }

        [TestMethod]
        public void ItIsARectangleWall()
        {
            object subject = SafeReflection.CreateInstance(typeSquare, new object[] { "TEST", "TESTCOLOR", 1 });
            Assert.IsInstanceOfType(subject, typeRectangle);
        }

        [TestMethod]
        public void GetAreaCalculatesCorrectArea()
        {
            object subject = SafeReflection.CreateInstance(typeSquare, new object[] { "TEST", "TESTCOLOR", 3 });
            object area = SafeReflection.InvokeMethod(subject, "GetArea", null);
            Assert.AreEqual(9, area);
        }

        [TestMethod]
        public void ToStringReturnsTheFormattedString()
        {
            object subject = SafeReflection.CreateInstance(typeSquare, new object[] { "TEST", "TESTCOLOR", 3 });
            Assert.AreEqual("TEST (3x3) square", subject.ToString());
        }
    }
}