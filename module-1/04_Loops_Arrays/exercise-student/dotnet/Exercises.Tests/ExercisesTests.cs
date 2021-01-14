using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass()]
    public class ExercisesTests
    {
        Exercises exercises = new Exercises();

        [TestMethod()]
        public void FirstLast6Test()
        {
            Assert.AreEqual(true, exercises.FirstLast6(new int[] { 1, 2, 6 }), "Test 1: Input was [1, 2, 6]");
            Assert.AreEqual(true, exercises.FirstLast6(new int[] { 6, 1, 2, 3 }), "Test 2: Input was [6, 1, 2, 3]");
            Assert.AreEqual(false, exercises.FirstLast6(new int[] { 13, 6, 1, 2, 3 }), "Test 3: Input was [13, 6, 1, 2, 3]");
        }

        [TestMethod()]
        public void SameFirstLastTest()
        {
            Assert.AreEqual(false, exercises.SameFirstLast(new int[] { 1, 2, 3 }), "Test 1: Input was [1, 2, 3]");
            Assert.AreEqual(true, exercises.SameFirstLast(new int[] { 1, 2, 3, 1 }), "Test 2: Input was [1, 2, 3, 1]");
            Assert.AreEqual(true, exercises.SameFirstLast(new int[] { 1, 2, 1 }), "Test 3: Input was [1, 2, 1]");
        }

        [TestMethod()]
        public void MakePiTest()
        {
            CollectionAssert.AreEqual(new int[] { 3, 1, 4 }, exercises.MakePi());
        }

        [TestMethod()]
        public void CommonEndTest()
        {
            Assert.AreEqual(true, exercises.CommonEnd(new int[] { 1, 2, 3 }, new int[] { 1, 5, 3 }), "Test 1: Input was [1, 2, 3] and [1, 5, 3]. It should return true.");
            Assert.AreEqual(false, exercises.CommonEnd(new int[] { 1, 2, 3 }, new int[] { 7, 3, 2 }), "Test 2: Input was [1, 2, 3] and [7, 3, 2]. It should return false.");
            Assert.AreEqual(true, exercises.CommonEnd(new int[] { 1, 2, 3 }, new int[] { 7, 3 }), "Test 3: Input was [1, 2, 3] and [7, 3]. Did you notice the arrays were different sizes?");
            Assert.AreEqual(true, exercises.CommonEnd(new int[] { 1, 2, 3 }, new int[] { 1, 3 }), "Test 4: Input was [1, 2, 3] and [1, 3]. Did you notice the arrays were different sizes?");
        }

        [TestMethod()]
        public void Sum3Test()
        {
            Assert.AreEqual(6, exercises.Sum3(new int[] { 1, 2, 3 }), "Test 1: Input was [1, 2, 3]");
            Assert.AreEqual(18, exercises.Sum3(new int[] { 5, 11, 2 }), "Test 2: Input was [5, 11, 2]");
            Assert.AreEqual(7, exercises.Sum3(new int[] { 7, 0, 0 }), "Test 3: Input was [7, 0, 0]");
        }

        [TestMethod()]
        public void RotateLeft3Test()
        {
            CollectionAssert.AreEqual(new int[] { 2, 3, 1 }, exercises.RotateLeft3(new int[] { 1, 2, 3 }), "Test 1: Input was [1, 2, 3]");
            CollectionAssert.AreEqual(new int[] { 11, 9, 5 }, exercises.RotateLeft3(new int[] { 5, 11, 9 }), "Test 2: Input was [5, 11, 9]");
            CollectionAssert.AreEqual(new int[] { 0, 0, 7 }, exercises.RotateLeft3(new int[] { 7, 0, 0 }), "Test 3: Input was [7, 0, 0]");
        }

        [TestMethod()]
        public void Reverse3Test()
        {
            CollectionAssert.AreEqual(new int[] { 3, 2, 1 }, exercises.Reverse3(new int[] { 1, 2, 3 }), "Test 1: Input was [1, 2, 3]");
            CollectionAssert.AreEqual(new int[] { 9, 11, 5 }, exercises.Reverse3(new int[] { 5, 11, 9 }), "Test 2: Input was [5, 11, 9]");
            CollectionAssert.AreEqual(new int[] { 0, 0, 7 }, exercises.Reverse3(new int[] { 7, 0, 0 }), "Test 3: Input was [7, 0, 0]");
        }

        [TestMethod()]
        public void MaxEnd3Test()
        {
            CollectionAssert.AreEqual(new int[] { 3, 3, 3 }, exercises.MaxEnd3(new int[] { 1, 2, 3 }), "Test 1: Input was [1, 2, 3]");
            CollectionAssert.AreEqual(new int[] { 11, 11, 11 }, exercises.MaxEnd3(new int[] { 11, 5, 9 }), "Test 2: Input was [11, 5, 9]");
            CollectionAssert.AreEqual(new int[] { 3, 3, 3 }, exercises.MaxEnd3(new int[] { 2, 11, 3 }), "Test 3: Input was [2, 11, 3]");
        }

        [TestMethod()]
        public void Sum2Test()
        {
            Assert.AreEqual(3, exercises.Sum2(new int[] { 1, 2, 3 }), "Test 1: Input was [1, 2, 3]");
            Assert.AreEqual(2, exercises.Sum2(new int[] { 1, 1 }), "Test 2: Input was [1, 1]");
            Assert.AreEqual(2, exercises.Sum2(new int[] { 1, 1, 1, 1 }), "Test 3: Input was [1, 1, 1, 1]");
            Assert.AreEqual(5, exercises.Sum2(new int[] { 5 }), "Test 4: Input was [5]");
            Assert.AreEqual(0, exercises.Sum2(new int[] { }), "Test 5: Input was []");
        }

        [TestMethod()]
        public void MiddleWayTest()
        {
            CollectionAssert.AreEqual(new int[] { 2, 5 }, exercises.MiddleWay(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }), "Test 1: Input was [1, 2, 3] and [4, 5, 6]");
            CollectionAssert.AreEqual(new int[] { 7, 8 }, exercises.MiddleWay(new int[] { 7, 7, 7 }, new int[] { 3, 8, 0 }), "Test 2: Input was [7, 7, 7] and [3, 8, 0]");
            CollectionAssert.AreEqual(new int[] { 2, 4 }, exercises.MiddleWay(new int[] { 5, 2, 9 }, new int[] { 1, 4, 5 }), "Test 3: Input was [5, 2, 9] and [1, 4, 5]");
        }

        [TestMethod()]
        public void CountEvensTest()
        {
            Assert.AreEqual(3, exercises.CountEvens(new int[] { 2, 1, 2, 3, 4 }), "Test 1: Input was [2, 1, 2, 3, 4]");
            Assert.AreEqual(3, exercises.CountEvens(new int[] { 2, 2, 0 }), "Test 2: Input was [2, 2, 0]. Array has three even numbers. ");
            Assert.AreEqual(0, exercises.CountEvens(new int[] { 1, 3, 5 }), "Test 3: Input was [1, 3, 5]. Array has no evens, make sure you start your total at 0.");
        }

        [TestMethod()]
        public void Sum13Test()
        {
            Assert.AreEqual(6, exercises.Sum13(new int[] { 1, 2, 2, 1 }), "Test 1: Input was [1, 2, 2, 1]");
            Assert.AreEqual(2, exercises.Sum13(new int[] { 1, 1 }), "Test 2: Input was [1, 1]");
            Assert.AreEqual(6, exercises.Sum13(new int[] { 1, 2, 2, 1, 13 }), "Test 3: Input was [1, 2, 2, 1, 13]");
            Assert.AreEqual(6, exercises.Sum13(new int[] { 1, 2, 2, 1, 13, 3 }), "Test 4: Input was [1, 2, 2, 1, 13, 3]");
            Assert.AreEqual(10, exercises.Sum13(new int[] { 1, 2, 2, 1, 13, 3, 4 }), "Test 5: Input was [11, 2, 2, 1, 13, 3, 4]");
            Assert.AreEqual(4, exercises.Sum13(new int[] { 1, 13, 2, 3, 13 }), "Test 6: Input was [1, 13, 2, 3, 13]");
            Assert.AreEqual(4, exercises.Sum13(new int[] { 1, 13, 2, 3, 13, 4 }), "Test 7: Input was [1, 13, 2, 3, 13, 4]");
            Assert.AreEqual(9, exercises.Sum13(new int[] { 1, 13, 2, 3, 13, 4, 5 }), "Test 8: Input was [1, 13, 2, 3, 13, 4, 5]");
            Assert.AreEqual(0, exercises.Sum13(new int[] { 13, 1, 13 }), "Test 9: Input was [13, 1, 13]");
            Assert.AreEqual(0, exercises.Sum13(new int[] { 13, 1, 13, 2 }), "Test 10: Input was [13, 1, 13, 2]");
            Assert.AreEqual(3, exercises.Sum13(new int[] { 13, 1, 13, 2, 3 }), "Test 11: Input was [13, 1, 13, 2, 3]");
            Assert.AreEqual(0, exercises.Sum13(new int[] { 13, 13, 13 }), "Test 12: Input was [13, 13, 13]");
            Assert.AreEqual(0, exercises.Sum13(new int[] { 13, 13, 13, 1 }), "Test 13: Input was [13, 13, 13, 1]");
            Assert.AreEqual(5, exercises.Sum13(new int[] { 13, 13, 13, 1, 2, 3 }), "Test 14: Input was [13, 13, 13, 1, 2, 3]");
        }

        [TestMethod()]
        public void Has22Test()
        {
            Assert.AreEqual(true, exercises.Has22(new int[] { 1, 2, 2, 3 }), "Test 1: Input was [1, 2, 2, 3] and should return true.");
            Assert.AreEqual(true, exercises.Has22(new int[] { 2, 2, 3 }), "Test 2: Input was [2, 2, 3] and should return true.");

            Assert.AreEqual(true, exercises.Has22(new int[] { 1, 2, 2 }), "Test 3: Input was [1, 2, 2] and should also return true.");
            Assert.AreEqual(false, exercises.Has22(new int[] { 1, 2, 1, 2 }), "Test 4: Input was [1, 2, 1, 2] and should return false.");
            Assert.AreEqual(false, exercises.Has22(new int[] { 2, 1, 2 }), "Test 5: Input was [2, 1, 2] and should return false.");

            Assert.AreEqual(true, exercises.Has22(new int[] { 2, 2, 2 }), "Test 6: Input was [2, 2, 2] and should also return true.");
            Assert.AreEqual(false, exercises.Has22(new int[] { 1, 2, 3, 4 }), "Test 7: Input was [1, 2, 3, 4] and should return false.");
            Assert.AreEqual(false, exercises.Has22(new int[] { 3, 4, 5 }), "Test 8: Input was [3, 4, 5] and should return false.");
        }

        [TestMethod()]
        public void Lucky13Test()
        {
            Assert.AreEqual(true, exercises.Lucky13(new int[] { 0, 2, 4 }), "Test 1: Input was [0, 2, 4]");
            Assert.AreEqual(false, exercises.Lucky13(new int[] { 1, 2, 3 }), "Test 2: Input was [1, 2, 3]");
            Assert.AreEqual(false, exercises.Lucky13(new int[] { 1, 2, 4 }), "Test 3: Input was [1, 2, 4]");
            Assert.AreEqual(false, exercises.Lucky13(new int[] { 5, 2, 3 }), "Test 4: Input was [5, 2, 3]");

            Assert.AreEqual(false, exercises.Lucky13(new int[] { 2, 1, 0 }), "Test 5: Input was [2, 1, 0]");
            Assert.AreEqual(false, exercises.Lucky13(new int[] { 2, 3, 0 }), "Test 6: Input was [2, 3, 0]");
            Assert.AreEqual(false, exercises.Lucky13(new int[] { 2, 4, 1 }), "Test 7: Input was [2, 4, 1]");
            Assert.AreEqual(false, exercises.Lucky13(new int[] { 3, 0, 2 }), "Test 8: Input was [3, 0, 2]");
            Assert.AreEqual(false, exercises.Lucky13(new int[] { 0, 3, 4 }), "Test 9: Input was [0, 3, 4]");
        }

        [TestMethod()]
        public void Sum28Test()
        {
            Assert.AreEqual(true, exercises.Sum28(new int[] { 2, 3, 2, 2, 4, 2 }), "Test 1: Input was [2, 3, 2, 2, 4, 2]");
            Assert.AreEqual(false, exercises.Sum28(new int[] { 2, 3, 2, 2, 4, 2, 2 }), "Test 2: Input was [2, 3, 2, 2, 4, 2, 2]");
            Assert.AreEqual(false, exercises.Sum28(new int[] { 1, 2, 3, 4 }), "Test 3: Input was [1, 2, 3, 4]");
        }
    }
}