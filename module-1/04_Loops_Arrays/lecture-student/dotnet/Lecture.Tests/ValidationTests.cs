using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lecture.Tests
{
    [TestClass]
    public class ValidationTests
    {
        private LectureProblem exercises = new LectureProblem();

        [TestMethod]
        public void Test_01a_ReturnNewArray()
        {
            Assert.IsNotNull(exercises.ReturnNewArray(), "Are you returning null?");
            Assert.AreEqual(typeof(int[]), exercises.ReturnNewArray().GetType(), "Did you make sure to return an array of integers?");
        }

        [TestMethod]
        public void Test_01b_ReturnArrayOfKnownSize()
        {
            Assert.IsNotNull(exercises.ReturnArrayOfKnownSize(), "Are you returning null?");
            Assert.AreEqual(typeof(int[]), exercises.ReturnArrayOfKnownSize().GetType(), "Did you make sure to return an array of integers?");
            Assert.AreEqual(100, exercises.ReturnArrayOfKnownSize().Length, "Is your array size set to 100?");
        }

        [TestMethod]
        public void Test_01c_ReturnArrayOfUnknownSize()
        {
            Assert.IsNotNull(exercises.ReturnArrayOfUnknownSize(10), "Are you returning null?");
            Assert.AreEqual(typeof(string[]), exercises.ReturnArrayOfUnknownSize(10).GetType(), "Did you make sure to return an array of integers?");
            Assert.AreEqual(10, exercises.ReturnArrayOfUnknownSize(10).Length, "Is your array size set using the parameter passed in?");
            Assert.AreEqual(100, exercises.ReturnArrayOfUnknownSize(100).Length, "Is your array size set using the parameter passed in?");
        }

        [TestMethod]
        public void Test_02a_ReturnFirstElement()
        {
            Assert.AreEqual(80, exercises.ReturnFirstElement(), "That's not the first element in that array");
        }

        [TestMethod]
        public void Test_03_ReturnLastElement()
        {
            Assert.AreEqual(443, exercises.ReturnLastElement(), "That's not the last element");
        }

        [TestMethod]
        public void Test_04a_ReturnFirstElementOfParam()
        {
            Assert.AreEqual(5, exercises.ReturnFirstElementOfParam(new int[] { 5, 10, 15 }), "That's not the first element from {5, 10, 15}");
            Assert.AreEqual(10, exercises.ReturnFirstElementOfParam(new int[] { 10, 20, 30, 40, 50 }), "That's not the first element from {10, 20, 30, 40, 50}");
        }

        [TestMethod]
        public void Test_04b_SetFirstElement()
        {
            int[] array = { 3, 5, 7, 9 };
            exercises.SetFirstElement(array);
            Assert.AreEqual(100, array[0], "Are you sure that you set the first element in the array to 100?");
        }

        [TestMethod]
        public void Test_05a_ReturnLastElementOfParam()
        {
            Assert.AreEqual(15, exercises.ReturnLastElementOfParam(new int[] { 5, 10, 15 }), "That's not the last element from {5, 10, 15}");
            Assert.AreEqual(50, exercises.ReturnLastElementOfParam(new int[] { 10, 20, 30, 40, 50 }), "That's not the last element from {10, 20, 30, 40, 50}");
        }

        [TestMethod]
        public void Test_05b_ReturnSecondToLastElementOfParam()
        {
            Assert.AreEqual(10, exercises.ReturnSecondToLastElementOfParam(new int[] { 5, 10, 15 }), "That's not second from the last element from {5, 10, 15}");
            Assert.AreEqual(40, exercises.ReturnSecondToLastElementOfParam(new int[] { 10, 20, 30, 40, 50 }), "That's not second from the last element from {10, 20, 30, 40, 50}");
        }

        [TestMethod]
        public void Test_05c_SetLastElement()
        {
            int[] array = { 3, 5, 7, 9 };
            exercises.SetLastElement(array);
            Assert.AreEqual(100, array[3], "Are you sure that you set the last element in the array to 100?");

            array = new int[] { 1, 1, 1 };
            exercises.SetLastElement(array);
            Assert.AreEqual(100, array[2], "Are you sure that you set the last element in the array to 100?");
        }

        [TestMethod]
        public void Test_06_ReturnCounterFromLoop()
        {
            Assert.AreEqual(18, exercises.ReturnSumArray(), "Are you sure you added correctly?");
        }

        [TestMethod]
        public void Test_07_ReturnCorrectSum()
        {
            Assert.AreEqual(18, exercises.ReturnCorrectSum(new int[] { 2, 0, 7, 9 }), "Are you sure all of the numbers are getting added?");
        }

        [TestMethod]
        public void Test_08_ReturnCorrectSumAgain()
        {
            Assert.AreEqual(18, exercises.ReturnCorrectSumAgain(new int[] { 2, 0, 7, 9 }), "Are you sure all of the numbers are getting added?");
        }

        [TestMethod]
        public void Test_09_ReturnSumEveryOtherNumber()
        {
            Assert.AreEqual(12, exercises.ReturnSumEveryOtherNumber(new int[] { 4, 3, 4, 1, 4, 6 }), "4 + 4 + 4 should add up to 12.");
        }

        [TestMethod]
        public void Test_10_ReturnHighestNumber()
        {
            Assert.AreEqual(13, exercises.FindTheHighestNumber(new int[] { 3, 12, 11, 13, 2, 4 }), "13 is the highest number in { 3, 12, 11, 13, 2, 4 }");
            Assert.AreEqual(103, exercises.FindTheHighestNumber(new int[] { 23, 12, 51, 103, 12, 4 }), "103 is the highest number in { 23, 12, 51, 103, 12, 4 }");
        }
    }
}
