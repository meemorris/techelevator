using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercise.Tests
{
    [TestClass]
    public class RectangleWallTests
    {
        private static readonly Type typeRectangle = SafeReflection.GetType("RectangleWall", "Exercise");
        private static readonly Type typeWall = SafeReflection.GetType("Wall", "Exercise");

        [TestMethod]
        public void ConstructorSetsTheProperties()
        {
            object subject = SafeReflection.CreateInstance(typeRectangle, new object[] { "TEST", "TESTCOLOR", 1, 2 });
            Assert.IsNotNull(subject);

            object subjectName = SafeReflection.GetPropertyValue(subject, "Name");
            object subjectColor = SafeReflection.GetPropertyValue(subject, "Color");
            object subjectLength = SafeReflection.GetPropertyValue(subject, "Length");
            object subjectHeight = SafeReflection.GetPropertyValue(subject, "Height");

            Assert.AreEqual("TEST", subjectName);
            Assert.AreEqual("TESTCOLOR", subjectColor);
            Assert.AreEqual(1, subjectLength);
            Assert.AreEqual(2, subjectHeight);
        }

        [TestMethod]
        public void ItIsAWall()
        {
            object subject = SafeReflection.CreateInstance(typeRectangle, new object[] { "TEST", "TESTCOLOR", 1, 2 });
            Assert.IsInstanceOfType(subject, typeWall);
        }

        [TestMethod]
        public void GetAreaCalculatesCorrectArea()
        {
            object subject = SafeReflection.CreateInstance(typeRectangle, new object[] { "TEST", "TESTCOLOR", 8, 9 });
            object area = SafeReflection.InvokeMethod(subject, "GetArea", null);
            Assert.AreEqual(72, area);
        }

        [TestMethod]
        public void ToStringReturnsTheFormattedString()
        {
            object subject = SafeReflection.CreateInstance(typeRectangle, new object[] { "TEST", "TESTCOLOR", 1, 3 });
            Assert.AreEqual("TEST (1x3) rectangle", subject.ToString());
        }
    }
}
