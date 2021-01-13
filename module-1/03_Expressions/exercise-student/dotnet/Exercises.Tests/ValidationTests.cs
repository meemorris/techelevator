using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class ValidationTests
    {
        private Exercises exercises = new Exercises();

        /*
	     SleepIn(false, false) → true
	     SleepIn(true, false) → false
	     SleepIn(false, true) → true
	    */
        [DataTestMethod]
        [DataRow(true, true, true)]
        [DataRow(true, false, false)]
        [DataRow(false, true, true)]
        [DataRow(false, false, true)]
        public void SleepIn(bool input1, bool input2, bool output)
        {
            Assert.AreEqual(output, exercises.SleepIn(input1, input2), $"Input: SleepIn ({input1.ToString()}, {input2.ToString()})");
        }

        /*
         MonkeyTrouble(true, true) → true
         MonkeyTrouble(false, false) → true
         MonkeyTrouble(true, false) → false
         */
        [DataTestMethod]
        [DataRow(true, true, true)]
        [DataRow(true, false, false)]
        [DataRow(false, true, false)]
        [DataRow(false, false, true)]
        public void MonkeyTrouble(bool input1, bool input2, bool output)
        {
            Assert.AreEqual(output, exercises.MonkeyTrouble(input1, input2), $"Input: MonkeyTrouble ({input1.ToString()}, {input2.ToString()})");
        }

        /*
         SumDouble(1, 2) → 3
         SumDouble(3, 2) → 5
         SumDouble(2, 2) → 8
         */
        [DataTestMethod]
        [DataRow(77, 173, 250)]
        [DataRow(-38, -37, -75)]
        [DataRow(194, 130, 324)]
        [DataRow(-173, 188, 15)]
        [DataRow(-232, -196, -428)]
        [DataRow(-134, -75, -209)]
        [DataRow(231, 231, 924)]
        [DataRow(111, -238, -127)]
        [DataRow(56, 78, 134)]
        [DataRow(157, -246, -89)]
        [DataRow(211, -152, 59)]
        [DataRow(59, 59, 236)]
        [DataRow(-6, -6, -24)]
        [DataRow(7, 7, 28)]
        [DataRow(154, 154, 616)]
        [DataRow(163, 163, 652)]
        [DataRow(-32, -32, -128)]
        [DataRow(176, -184, -8)]
        [DataRow(225, -117, 108)]
        [DataRow(121, 121, 484)]
        [DataRow(-251, -222, -473)]
        [DataRow(-179, -203, -382)]
        [DataRow(195, -252, -57)]
        [DataRow(-150, -150, -600)]
        [DataRow(-188, -188, -752)]
        [DataRow(49, 49, 196)]
        [DataRow(-130, -61, -191)]
        [DataRow(-11, 216, 205)]
        [DataRow(-34, 65, 31)]
        [DataRow(-173, -71, -244)]
        [DataRow(163, 163, 652)]
        [DataRow(118, -111, 7)]
        public void SumDouble(int input1, int input2, int output)
        {
            Assert.AreEqual(output, exercises.SumDouble(input1, input2), $"Input: SumDouble ({input1.ToString()}, {input2.ToString()})");
        }

        /*
         Diff21(19) → 2
         Diff21(10) → 11
         Diff21(21) → 0
         */
        [DataTestMethod]
        [DataRow(-4, 25)]
        [DataRow(45, 48)]
        [DataRow(29, 16)]
        [DataRow(-7, 28)]
        [DataRow(-27, 48)]
        [DataRow(7, 14)]
        [DataRow(-33, 54)]
        [DataRow(-30, 51)]
        [DataRow(31, 20)]
        [DataRow(24, 6)]
        [DataRow(-32, 53)]
        [DataRow(-44, 65)]
        [DataRow(-4, 25)]
        [DataRow(-42, 63)]
        [DataRow(46, 50)]
        [DataRow(-19, 40)]
        [DataRow(0, 21)]
        [DataRow(-38, 59)]
        [DataRow(-38, 59)]
        [DataRow(43, 44)]
        [DataRow(-48, 69)]
        [DataRow(-12, 33)]
        [DataRow(2, 19)]
        [DataRow(21, 0)]
        [DataRow(22, 2)]
        [DataRow(20, 1)]
        [DataRow(-22, 43)]
        [DataRow(-21, 42)]
        [DataRow(-20, 41)]
        public void Diff21(int input, int output)
        {
            Assert.AreEqual(output, exercises.Diff21(input), $"Input: Diff21 ({input.ToString()})");
        }

        /*
         ParrotTrouble(true, 6) → true
         ParrotTrouble(true, 7) → false
         ParrotTrouble(false, 6) → false
         */
        [DataTestMethod]
        [DataRow(true, 0, true)]
        [DataRow(true, 1, true)]
        [DataRow(true, 2, true)]
        [DataRow(true, 3, true)]
        [DataRow(true, 4, true)]
        [DataRow(true, 5, true)]
        [DataRow(true, 6, true)]
        [DataRow(true, 7, false)]
        [DataRow(true, 8, false)]
        [DataRow(true, 9, false)]
        [DataRow(true, 10, false)]
        [DataRow(true, 11, false)]
        [DataRow(true, 12, false)]
        [DataRow(true, 13, false)]
        [DataRow(true, 14, false)]
        [DataRow(true, 15, false)]
        [DataRow(true, 16, false)]
        [DataRow(true, 17, false)]
        [DataRow(true, 18, false)]
        [DataRow(true, 19, false)]
        [DataRow(true, 20, false)]
        [DataRow(true, 21, true)]
        [DataRow(true, 22, true)]
        [DataRow(true, 23, true)]
        [DataRow(false, 0, false)]
        [DataRow(false, 1, false)]
        [DataRow(false, 2, false)]
        [DataRow(false, 3, false)]
        [DataRow(false, 4, false)]
        [DataRow(false, 5, false)]
        [DataRow(false, 6, false)]
        [DataRow(false, 7, false)]
        [DataRow(false, 8, false)]
        [DataRow(false, 9, false)]
        [DataRow(false, 10, false)]
        [DataRow(false, 11, false)]
        [DataRow(false, 12, false)]
        [DataRow(false, 13, false)]
        [DataRow(false, 14, false)]
        [DataRow(false, 15, false)]
        [DataRow(false, 16, false)]
        [DataRow(false, 17, false)]
        [DataRow(false, 18, false)]
        [DataRow(false, 19, false)]
        [DataRow(false, 20, false)]
        [DataRow(false, 21, false)]
        [DataRow(false, 22, false)]
        [DataRow(false, 23, false)]
        public void ParrotTrouble(bool input1, int input2, bool output)
        {
            Assert.AreEqual(output, exercises.ParrotTrouble(input1, input2), $"Input: ParrotTrouble ({input1}, {input2})");
        }

        /*
         Makes10(9, 10) → true
         Makes10(9, 9) → false
         Makes10(1, 9) → true
         */
        [DataTestMethod]
        [DataRow(-16, 2, false)]
        [DataRow(-3, 13, true)]
        [DataRow(15, 0, false)]
        [DataRow(1, 9, true)]
        [DataRow(5, -1, false)]
        [DataRow(20, -14, false)]
        [DataRow(-15, -11, false)]
        [DataRow(15, -1, false)]
        [DataRow(-3, -3, false)]
        [DataRow(14, -4, true)]
        [DataRow(4, 6, true)]
        [DataRow(4, 6, true)]
        [DataRow(-3, 3, false)]
        [DataRow(-7, 17, true)]
        [DataRow(16, -12, false)]
        [DataRow(2, 8, true)]
        [DataRow(-10, 20, true)]
        [DataRow(19, -9, true)]
        [DataRow(16, -8, false)]
        [DataRow(16, -18, false)]
        [DataRow(-1, -16, false)]
        [DataRow(12, -2, true)]
        [DataRow(1, 9, true)]
        [DataRow(1, -13, false)]
        [DataRow(5, 5, true)]
        [DataRow(16, -6, true)]
        [DataRow(-3, 7, false)]
        [DataRow(20, -10, true)]
        [DataRow(-9, 19, true)]
        [DataRow(-2, 2, false)]
        [DataRow(-5, -18, false)]
        [DataRow(-17, -3, false)]
        [DataRow(5, 11, false)]
        [DataRow(0, 16, false)]
        [DataRow(18, -8, true)]
        [DataRow(9, 1, true)]
        [DataRow(4, 6, true)]
        [DataRow(15, -5, true)]
        [DataRow(-18, -7, false)]
        [DataRow(10, 9, true)]
        [DataRow(10, 0, true)]
        [DataRow(10, -18, true)]
        [DataRow(10, 0, true)]
        [DataRow(5, 10, true)]
        [DataRow(-19, 10, true)]
        [DataRow(-20, 10, true)]
        [DataRow(19, 10, true)]
        [DataRow(-17, 10, true)]
        [DataRow(-8, 10, true)]
        [DataRow(-4, 10, true)]
        [DataRow(-6, 10, true)]
        [DataRow(-18, 10, true)]
        public void Makes10(int input1, int input2, bool output)
        {
            Assert.AreEqual(output, exercises.Makes10(input1, input2), $"Input: Makes10 ({input1}, {input2})");
        }

        /*
         PosNeg(1, -1, false) → true
         PosNeg(-1, 1, false) → true
         PosNeg(-4, -5, true) → true
         */
        [DataTestMethod]
        [DataRow(-174, 182, false, true)]
        [DataRow(-157, -55, false, false)]
        [DataRow(-164, 63, true, false)]
        [DataRow(-54, 128, true, false)]
        [DataRow(-60, -114, true, true)]
        [DataRow(14, 23, false, false)]
        [DataRow(-253, 1, false, true)]
        [DataRow(244, -10, true, false)]
        [DataRow(236, -70, false, true)]
        [DataRow(145, -96, true, false)]
        [DataRow(-6, 80, true, false)]
        [DataRow(-178, 27, false, true)]
        [DataRow(207, -11, false, true)]
        [DataRow(-234, -90, false, false)]
        [DataRow(-59, 44, true, false)]
        [DataRow(28, 184, true, false)]
        [DataRow(20, -17, true, false)]
        [DataRow(67, -247, true, false)]
        [DataRow(-189, 145, true, false)]
        [DataRow(-195, 97, false, true)]
        [DataRow(-16, 185, false, true)]
        [DataRow(231, -130, true, false)]
        [DataRow(179, -84, false, true)]
        [DataRow(-252, 108, false, true)]
        [DataRow(-120, 40, true, false)]
        [DataRow(-54, 76, false, true)]
        [DataRow(56, 33, false, false)]
        [DataRow(82, 215, true, false)]
        [DataRow(-193, 137, false, true)]
        [DataRow(-110, -211, false, false)]
        [DataRow(247, -102, false, true)]
        [DataRow(-110, -129, true, true)]
        [DataRow(3, -118, false, true)]
        [DataRow(-198, -128, false, false)]
        [DataRow(235, -179, false, true)]
        [DataRow(-113, 57, false, true)]
        public void PosNeg(int input1, int input2, bool input3, bool output)
        {
            Assert.AreEqual(output, exercises.PosNeg(input1, input2, input3), $"Input: PosNeg ({input1}, {input2}, {input3.ToString()})");
        }

        /*
         Or35(3) → true
         Or35(10) → true
         Or35(8) → false
         */
        [DataTestMethod]
        [DataRow(3, true)]
        [DataRow(5, true)]
        [DataRow(7, false)]
        [DataRow(30, true)]
        [DataRow(29, false)]
        [DataRow(24, true)]
        [DataRow(44, false)]
        [DataRow(19, false)]
        [DataRow(4, false)]
        [DataRow(1, false)]
        [DataRow(0, true)]
        [DataRow(32, false)]
        [DataRow(26, false)]
        [DataRow(20, true)]
        [DataRow(13, false)]
        [DataRow(31, false)]
        [DataRow(15, true)]
        [DataRow(17, false)]
        [DataRow(21, true)]
        [DataRow(21, true)]
        [DataRow(1, false)]
        [DataRow(22, false)]
        [DataRow(0, true)]
        [DataRow(23, false)]
        [DataRow(6, true)]
        [DataRow(50, true)]
        [DataRow(24, true)]
        [DataRow(2, false)]
        [DataRow(19, false)]
        [DataRow(25, true)]
        [DataRow(24, true)]
        [DataRow(38, false)]
        [DataRow(16, false)]
        [DataRow(6, true)]
        [DataRow(32, false)]
        [DataRow(23, false)]
        public void Or35(int input1, bool output)
        {
            Assert.AreEqual(output, exercises.Or35(input1), $"Input: Or35 ({input1})");
        }

        /*
         IcyHot(120, -1) → true
         IcyHot(-1, 120) → true
         IcyHot(2, 120) → false
         */
        [DataTestMethod]
        [DataRow(120, -1, true)]
        [DataRow(-1, 120, true)]
        [DataRow(2, 120, false)]
        [DataRow(20, -30, false)]
        [DataRow(128, -7, true)]
        [DataRow(10, 27, false)]
        [DataRow(146, 78, false)]
        [DataRow(-37, 68, false)]
        [DataRow(-35, -49, false)]
        [DataRow(51, 49, false)]
        [DataRow(-33, 66, false)]
        [DataRow(-9, 26, false)]
        [DataRow(137, 30, false)]
        [DataRow(51, 98, false)]
        [DataRow(52, 136, false)]
        [DataRow(-14, 8, false)]
        [DataRow(95, 44, false)]
        [DataRow(140, -6, true)]
        [DataRow(19, 75, false)]
        [DataRow(41, 84, false)]
        [DataRow(27, -49, false)]
        [DataRow(-3, 4, false)]
        [DataRow(144, -29, true)]
        [DataRow(134, 98, false)]
        [DataRow(14, 89, false)]
        [DataRow(129, 120, false)]
        [DataRow(73, -23, false)]
        [DataRow(86, -35, false)]
        [DataRow(-29, 118, true)]
        [DataRow(5, -29, false)]
        [DataRow(123, 4, false)]
        [DataRow(134, 122, false)]
        [DataRow(124, 35, false)]
        [DataRow(36, 29, false)]
        [DataRow(-33, 107, true)]
        [DataRow(141, 90, false)]
        [DataRow(-18, 41, false)]
        [DataRow(14, 96, false)]
        [DataRow(16, 99, false)]
        [DataRow(144, -23, true)]
        [DataRow(84, 87, false)]
        [DataRow(7, 41, false)]
        [DataRow(42, -23, false)]
        [DataRow(31, 95, false)]
        [DataRow(57, 77, false)]
        [DataRow(81, 40, false)]
        [DataRow(55, 1, false)]
        [DataRow(94, -31, false)]
        [DataRow(43, 3, false)]
        [DataRow(-45, 79, false)]
        [DataRow(-17, 135, true)]
        [DataRow(-47, -11, false)]
        [DataRow(127, 50, false)]
        [DataRow(-3, 125, true)]
        [DataRow(36, 84, false)]
        [DataRow(-27, 136, true)]
        [DataRow(0, -47, false)]
        [DataRow(0, -15, false)]
        [DataRow(0, 136, false)]
        [DataRow(0, 94, false)]
        [DataRow(0, 112, false)]
        [DataRow(132, 0, false)]
        [DataRow(139, 0, false)]
        [DataRow(61, 0, false)]
        [DataRow(18, 0, false)]
        [DataRow(13, 0, false)]
        [DataRow(100, 118, false)]
        [DataRow(100, 25, false)]
        [DataRow(100, 110, false)]
        [DataRow(100, 107, false)]
        [DataRow(100, 119, false)]
        [DataRow(-11, 100, false)]
        [DataRow(91, 100, false)]
        [DataRow(44, 100, false)]
        [DataRow(63, 100, false)]
        [DataRow(-15, 100, false)]
        public void IcyHot(int input1, int input2, bool output)
        {
            Assert.AreEqual(output, exercises.IcyHot(input1, input2), $"Input: IcyHot ({input1}, {input2})");
        }

        /*
         In1020(12, 99) → true
         In1020(21, 12) → true
         In1020(8, 99) → false
         */
        [DataTestMethod]
        [DataRow(12, 99, true)]
        [DataRow(21, 12, true)]
        [DataRow(8, 99, false)]
        [DataRow(19, -15, true)]
        [DataRow(17, -28, true)]
        [DataRow(17, 7, true)]
        [DataRow(14, -24, true)]
        [DataRow(20, -26, true)]
        [DataRow(13, 13, true)]
        [DataRow(13, 20, true)]
        [DataRow(15, 11, true)]
        [DataRow(14, 20, true)]
        [DataRow(12, 11, true)]
        [DataRow(17, 35, true)]
        [DataRow(12, 40, true)]
        [DataRow(12, 49, true)]
        [DataRow(14, 30, true)]
        [DataRow(20, 35, true)]
        [DataRow(16, 21, true)]
        [DataRow(2, 15, true)]
        [DataRow(-21, 16, true)]
        [DataRow(-33, 19, true)]
        [DataRow(-15, 12, true)]
        [DataRow(2, 18, true)]
        [DataRow(12, 16, true)]
        [DataRow(13, 18, true)]
        [DataRow(11, 11, true)]
        [DataRow(14, 18, true)]
        [DataRow(17, 18, true)]
        [DataRow(23, 11, true)]
        [DataRow(27, 10, true)]
        [DataRow(28, 14, true)]
        [DataRow(23, 17, true)]
        [DataRow(35, 12, true)]
        [DataRow(41, 18, true)]
        public void In1020(int input1, int input2, bool output)
        {
            Assert.AreEqual(output, exercises.In1020(input1, input2), $"Input: In1020 ({input1}, {input2})");
        }

        /*
         HasTeen(13, 20, 10) → true
         HasTeen(20, 19, 10) → true
         HasTeen(20, 10, 13) → true
         */
        [DataTestMethod]
        [DataRow(13, 20, 10, true)]
        [DataRow(20, 19, 10, true)]
        [DataRow(20, 10, 13, true)]
        [DataRow(10, 10, 10, false)]
        [DataRow(20, 20, 20, false)]
        [DataRow(16, 17, 19, true)]
        [DataRow(14, 14, 19, true)]
        [DataRow(13, 16, 16, true)]
        [DataRow(17, 19, -14, true)]
        [DataRow(19, 18, 11, true)]
        [DataRow(16, 13, 37, true)]
        [DataRow(19, -3, 14, true)]
        [DataRow(13, 3, 17, true)]
        [DataRow(18, 25, 19, true)]
        [DataRow(13, -17, -19, true)]
        [DataRow(17, 1, 10, true)]
        [DataRow(15, 37, 22, true)]
        [DataRow(-20, 19, 17, true)]
        [DataRow(6, 18, 15, true)]
        [DataRow(22, 15, 18, true)]
        [DataRow(-5, 13, -6, true)]
        [DataRow(0, 19, 12, true)]
        [DataRow(21, 14, 35, true)]
        [DataRow(-13, -1, 18, true)]
        [DataRow(11, 7, 17, true)]
        [DataRow(40, 26, 13, true)]
        [DataRow(-10, -10, -6, false)]
        [DataRow(3, 5, 11, false)]
        [DataRow(20, 22, 31, false)]

        public void HasTeen(int input1, int input2, int input3, bool output)
        {
            Assert.AreEqual(output, exercises.HasTeen(input1, input2, input3), $"Input: HasTeen ({input1}, {input2}, {input3})");
        }

        /*
         LoneTeen(13, 99) → true
         LoneTeen(21, 19) → true
         LoneTeen(13, 13) → false
         */
        [DataTestMethod]
        [DataRow(13, 99, true)]
        [DataRow(21, 19, true)]
        [DataRow(13, 13, false)]
        [DataRow(17, 19, false)]
        [DataRow(16, 19, false)]
        [DataRow(19, 13, false)]
        [DataRow(17, -18, true)]
        [DataRow(14, 10, true)]
        [DataRow(19, 31, true)]
        [DataRow(-20, 16, true)]
        [DataRow(12, 13, true)]
        [DataRow(23, 19, true)]
        [DataRow(-12, -20, false)]
        [DataRow(2, 2, false)]
        [DataRow(23, 20, false)]
        public void LoneTeen(int input1, int input2, bool output)
        {
            Assert.AreEqual(output, exercises.LoneTeen(input1, input2), $"Input: LoneTeen ({input1}, {input2})");
        }

        /*
         IntMax(1, 2, 3) → 3
         IntMax(1, 3, 2) → 3
         IntMax(3, 2, 1) → 3
         */
        [DataTestMethod]
        [DataRow(1, 2, 3, 3)]
        [DataRow(1, 3, 2, 3)]
        [DataRow(3, 2, 1, 3)]
        [DataRow(-92, -15, 77, 77)]
        [DataRow(-70, -14, 65, 65)]
        [DataRow(-99, 23, 90, 90)]
        [DataRow(2, 58, 95, 95)]
        [DataRow(27, 34, 68, 68)]
        [DataRow(20, 60, 67, 67)]
        [DataRow(69, -82, 5, 69)]
        [DataRow(89, -86, -17, 89)]
        [DataRow(93, -66, 5, 93)]
        [DataRow(71, 14, 38, 71)]
        [DataRow(83, 6, 57, 83)]
        [DataRow(61, 18, 57, 61)]
        [DataRow(-25, 58, -55, 58)]
        [DataRow(23, 26, -54, 26)]
        [DataRow(-16, 73, -69, 73)]
        [DataRow(41, 81, 25, 81)]
        [DataRow(60, 100, 24, 100)]
        [DataRow(52, 83, 2, 83)]
        public void IntMax(int input1, int input2, int input3, int output)
        {
            Assert.AreEqual(output, exercises.IntMax(input1, input2, input3), $"Input: IntMax ({input1}, {input2}, {input3})");
        }

        /*
         In3050(30, 31) → true
         In3050(30, 41) → false
         In3050(40, 50) → true
         */
        [DataTestMethod]
        [DataRow(30, 30, true)]
        [DataRow(30, 31, true)]
        [DataRow(32, 32, true)]
        [DataRow(35, 32, true)]
        [DataRow(38, 39, true)]
        [DataRow(39, 38, true)]
        [DataRow(40, 40, true)]
        [DataRow(40, 39, true)]
        [DataRow(39, 40, true)]
        [DataRow(-20, 30, false)]
        [DataRow(29, 35, false)]
        [DataRow(0, 40, false)]
        [DataRow(41, 30, false)]
        [DataRow(45, 35, false)]
        [DataRow(100, 40, false)]
        [DataRow(-20, -15, false)]
        [DataRow(0, 0, false)]
        [DataRow(20, 29, false)]
        [DataRow(10, 50, false)]
        [DataRow(29, 41, false)]
        [DataRow(40, 40, true)]
        [DataRow(40, 41, true)]
        [DataRow(42, 42, true)]
        [DataRow(45, 42, true)]
        [DataRow(48, 49, true)]
        [DataRow(49, 48, true)]
        [DataRow(50, 50, true)]
        [DataRow(50, 49, true)]
        [DataRow(49, 50, true)]
        [DataRow(-10, 40, false)]
        [DataRow(39, 45, false)]
        [DataRow(10, 50, false)]
        [DataRow(51, 40, false)]
        [DataRow(55, 45, false)]
        [DataRow(110, 50, false)]
        [DataRow(-10, -5, false)]
        [DataRow(10, 10, false)]
        [DataRow(30, 39, true)]
        [DataRow(20, 60, false)]
        [DataRow(39, 51, false)]
        public void In3050(int i1, int i2, bool op)
        {
            Assert.AreEqual(op, exercises.In3050(i1, i2), $"Input: In3050 ({i1}, {i2})");
        }

        /*
         Max1020(11, 19) → 19
         Max1020(19, 11) → 19
         Max1020(11, 9) → 11
         */
        [DataTestMethod]
        [DataRow(-10, -10, 0)]
        [DataRow(5, 5, 0)]
        [DataRow(10, 10, 10)]
        [DataRow(15, 15, 15)]
        [DataRow(20, 20, 20)]
        [DataRow(25, 25, 0)]
        [DataRow(30, 30, 0)]
        [DataRow(-10, -8, 0)]
        [DataRow(5, 7, 0)]
        [DataRow(10, 12, 12)]
        [DataRow(15, 17, 17)]
        [DataRow(20, 22, 20)]
        [DataRow(25, 27, 0)]
        [DataRow(30, 32, 0)]
        [DataRow(-10, -12, 0)]
        [DataRow(5, 3, 0)]
        [DataRow(10, 8, 10)]
        [DataRow(15, 13, 15)]
        [DataRow(20, 18, 20)]
        [DataRow(25, 23, 0)]
        [DataRow(30, 28, 0)]
        [DataRow(-8, -10, 0)]
        [DataRow(7, 5, 0)]
        [DataRow(12, 10, 12)]
        [DataRow(17, 15, 17)]
        [DataRow(22, 20, 20)]
        [DataRow(27, 25, 0)]
        [DataRow(32, 30, 0)]
        [DataRow(-12, -10, 0)]
        [DataRow(3, 5, 0)]
        [DataRow(8, 10, 10)]
        [DataRow(13, 15, 15)]
        [DataRow(18, 20, 20)]
        [DataRow(23, 25, 0)]
        [DataRow(28, 30, 0)]
        public void Max1020(int i1, int i2, int op)
        {
            Assert.AreEqual(op, exercises.Max1020(i1, i2), $"Input: Max1020 ({i1}, {i2})");
        }

        /*
         CigarParty(30, false) → false
         CigarParty(50, false) → true
         CigarParty(70, true) → true
         */
        [DataTestMethod]
        [DataRow(0, true, false)]
        [DataRow(10, true, false)]
        [DataRow(20, true, false)]
        [DataRow(30, true, false)]
        [DataRow(39, true, false)]
        [DataRow(40, true, true)]
        [DataRow(41, true, true)]
        [DataRow(42, true, true)]
        [DataRow(45, true, true)]
        [DataRow(48, true, true)]
        [DataRow(49, true, true)]
        [DataRow(50, true, true)]
        [DataRow(51, true, true)]
        [DataRow(55, true, true)]
        [DataRow(60, true, true)]
        [DataRow(70, true, true)]
        [DataRow(80, true, true)]
        [DataRow(90, true, true)]
        [DataRow(100, true, true)]
        [DataRow(1000, true, true)]
        [DataRow(10000, true, true)]
        [DataRow(0, false, false)]
        [DataRow(10, false, false)]
        [DataRow(20, false, false)]
        [DataRow(30, false, false)]
        [DataRow(39, false, false)]
        [DataRow(40, false, true)]
        [DataRow(41, false, true)]
        [DataRow(42, false, true)]
        [DataRow(45, false, true)]
        [DataRow(48, false, true)]
        [DataRow(49, false, true)]
        [DataRow(50, false, true)]
        [DataRow(51, false, true)]
        [DataRow(55, false, true)]
        [DataRow(60, false, true)]
        [DataRow(70, false, false)]
        [DataRow(80, false, false)]
        [DataRow(90, false, false)]
        [DataRow(100, false, false)]
        [DataRow(1000, false, false)]
        [DataRow(10000, false, false)]
        public void CigarParty(int i1, bool i2, bool op)
        {
            Assert.AreEqual(op, exercises.CigarParty(i1, i2), $"Input: CigarParty ({i1}, {i2})");
        }

        /*
         DateFashion(5, 10) → 2
         DateFashion(5, 2) → 0
         DateFashion(5, 5) → 1
         */
        [DataTestMethod]
        [DataRow(5, 10, 2)]
        [DataRow(5, 2, 0)]
        [DataRow(5, 5, 1)]
        [DataRow(0, 0, 0)]
        [DataRow(1, 1, 0)]
        [DataRow(2, 2, 0)]
        [DataRow(3, 3, 1)]
        [DataRow(7, 7, 1)]
        [DataRow(8, 8, 2)]
        [DataRow(9, 9, 2)]
        [DataRow(10, 10, 2)]
        [DataRow(0, 1, 0)]
        [DataRow(1, 1, 0)]
        [DataRow(2, 1, 0)]
        [DataRow(3, 1, 0)]
        [DataRow(7, 1, 0)]
        [DataRow(8, 1, 0)]
        [DataRow(9, 1, 0)]
        [DataRow(10, 1, 0)]
        [DataRow(0, 2, 0)]
        [DataRow(1, 2, 0)]
        [DataRow(2, 2, 0)]
        [DataRow(3, 2, 0)]
        [DataRow(7, 2, 0)]
        [DataRow(8, 2, 0)]
        [DataRow(9, 2, 0)]
        [DataRow(10, 2, 0)]
        [DataRow(0, 3, 0)]
        [DataRow(1, 3, 0)]
        [DataRow(2, 3, 0)]
        [DataRow(3, 3, 1)]
        [DataRow(7, 3, 1)]
        [DataRow(8, 3, 2)]
        [DataRow(9, 3, 2)]
        [DataRow(10, 3, 2)]
        [DataRow(0, 7, 0)]
        [DataRow(1, 7, 0)]
        [DataRow(2, 7, 0)]
        [DataRow(3, 7, 1)]
        [DataRow(7, 7, 1)]
        [DataRow(8, 7, 2)]
        [DataRow(9, 7, 2)]
        [DataRow(10, 7, 2)]
        [DataRow(0, 8, 0)]
        [DataRow(1, 8, 0)]
        [DataRow(2, 8, 0)]
        [DataRow(3, 8, 2)]
        [DataRow(7, 8, 2)]
        [DataRow(8, 8, 2)]
        [DataRow(9, 8, 2)]
        [DataRow(10, 8, 2)]
        [DataRow(0, 9, 0)]
        [DataRow(1, 9, 0)]
        [DataRow(2, 9, 0)]
        [DataRow(3, 9, 2)]
        [DataRow(7, 9, 2)]
        [DataRow(8, 9, 2)]
        [DataRow(9, 9, 2)]
        [DataRow(10, 9, 2)]
        public void DateFashion(int ip1, int ip2, int op)
        {
            Assert.AreEqual(op, exercises.DateFashion(ip1, ip2), $"Input: DateFashion ({ip1}, {ip2})");
        }

        /*
         SquirrelPlay(70, false) → true
         SquirrelPlay(95, false) → false
         SquirrelPlay(95, true) → true
         */
        [DataTestMethod]
        [DataRow(0, true, false)]
        [DataRow(10, true, false)]
        [DataRow(20, true, false)]
        [DataRow(30, true, false)]
        [DataRow(40, true, false)]
        [DataRow(50, true, false)]
        [DataRow(55, true, false)]
        [DataRow(59, true, false)]
        [DataRow(60, true, true)]
        [DataRow(61, true, true)]
        [DataRow(65, true, true)]
        [DataRow(70, true, true)]
        [DataRow(75, true, true)]
        [DataRow(80, true, true)]
        [DataRow(85, true, true)]
        [DataRow(89, true, true)]
        [DataRow(90, true, true)]
        [DataRow(91, true, true)]
        [DataRow(95, true, true)]
        [DataRow(99, true, true)]
        [DataRow(100, true, true)]
        [DataRow(101, true, false)]
        [DataRow(105, true, false)]
        [DataRow(110, true, false)]
        [DataRow(120, true, false)]
        [DataRow(0, false, false)]
        [DataRow(10, false, false)]
        [DataRow(20, false, false)]
        [DataRow(30, false, false)]
        [DataRow(40, false, false)]
        [DataRow(50, false, false)]
        [DataRow(55, false, false)]
        [DataRow(59, false, false)]
        [DataRow(60, false, true)]
        [DataRow(61, false, true)]
        [DataRow(65, false, true)]
        [DataRow(70, false, true)]
        [DataRow(75, false, true)]
        [DataRow(80, false, true)]
        [DataRow(85, false, true)]
        [DataRow(89, false, true)]
        [DataRow(90, false, true)]
        [DataRow(91, false, false)]
        [DataRow(95, false, false)]
        [DataRow(99, false, false)]
        [DataRow(100, false, false)]
        [DataRow(101, false, false)]
        [DataRow(105, false, false)]
        [DataRow(110, false, false)]
        [DataRow(120, false, false)]
        public void SquirrelPlay(int i1, bool i2, bool op)
        {
            Assert.AreEqual(op, exercises.SquirrelPlay(i1, i2), $"Input: SquirrelPlay ({i1}, {i2})");
        }

        /*
         YourCakeAndEatItToo(4.99, false) → "standard"
         YourCakeAndEatItToo(4.99, true) → "standard"
         YourCakeAndEatItToo(7.00, false) → "standard"
         YourCakeAndEatItToo(7.00, true) → "special"
         YourCakeAndEatItToo(10.00, false) → "standard"
         YourCakeAndEatItToo(10.00, true) → "special"
         YourCakeAndEatItToo(10.01, false) → "special"
         YourCakeAndEatItToo(10.01, true) → "ginormous"
         */
        [DataTestMethod]
        [DataRow(4.99, false, "standard")]
        [DataRow(4.99, true, "standard")]
        [DataRow(7.00, false, "standard")]
        [DataRow(7.00, true, "special")]
        [DataRow(10.00, false, "standard")]
        [DataRow(10.00, true, "special")]
        [DataRow(10.01, false, "special")]
        [DataRow(10.01, true, "ginormous")]
        [DataRow(15.00, false, "special")]
        [DataRow(15.00, true, "ginormous")]
        [DataRow(15.01, false, "ginormous")]
        [DataRow(15.01, true, "ginormous")]
        public void YourCakeAndEatItToo(double mealAmount, bool isBirthday, string expected)
        {
            Assert.AreEqual(expected, exercises.YourCakeAndEatItToo(mealAmount, isBirthday), $"Input: YourCakeAndEatItToo ({mealAmount}, {isBirthday})");
        }

        /*
         SortaSum(3, 4) → 7
         SortaSum(9, 4) → 20
         SortaSum(10, 11) → 21
         */
        [DataTestMethod]
        [DataRow(-5, -15, -20)]
        [DataRow(8, -18, -10)]
        [DataRow(-21, 16, -5)]
        [DataRow(18, -18, 0)]
        [DataRow(13, -13, 0)]
        [DataRow(11, -6, 5)]
        [DataRow(-10, 19, 9)]
        [DataRow(1, 8, 9)]
        [DataRow(12, -2, 20)]
        [DataRow(18, -8, 20)]
        [DataRow(17, -6, 20)]
        [DataRow(-6, 17, 20)]
        [DataRow(-5, 17, 20)]
        [DataRow(-19, 32, 20)]
        [DataRow(24, -10, 20)]
        [DataRow(-22, 37, 20)]
        [DataRow(-1, 17, 20)]
        [DataRow(-5, 22, 20)]
        [DataRow(11, 7, 20)]
        [DataRow(20, -2, 20)]
        [DataRow(3, 16, 20)]
        [DataRow(-20, 39, 20)]
        [DataRow(-13, 33, 20)]
        [DataRow(19, 1, 20)]
        [DataRow(-10, 35, 25)]
        [DataRow(24, 6, 30)]
        [DataRow(-7, 42, 35)]
        [DataRow(24, 16, 40)]
        public void SortaSum(int ip1, int ip2, int op)
        {
            Assert.AreEqual(op, exercises.SortaSum(ip1, ip2), $"Input: SortaSum ({ip1}, {ip2})");
        }

        /*
         AlarmClock(1, false) → "7:00"
         AlarmClock(5, false) → "7:00"
         AlarmClock(0, false) → "10:00"
         */
        [DataTestMethod]
        [DataRow(0, true, "off")]
        [DataRow(1, true, "10:00")]
        [DataRow(2, true, "10:00")]
        [DataRow(3, true, "10:00")]
        [DataRow(4, true, "10:00")]
        [DataRow(5, true, "10:00")]
        [DataRow(6, true, "off")]
        [DataRow(0, false, "10:00")]
        [DataRow(1, false, "7:00")]
        [DataRow(2, false, "7:00")]
        [DataRow(3, false, "7:00")]
        [DataRow(4, false, "7:00")]
        [DataRow(5, false, "7:00")]
        [DataRow(6, false, "10:00")]
        public void AlarmClock(int ip1, bool ip2, string op)
        {
            Assert.AreEqual(op, exercises.AlarmClock(ip1, ip2), $"Input: AlarmClock ({ip1}, {ip2})");
        }

        /*
         In1To10(5, false) → true
         In1To10(11, false) → false
         In1To10(11, true) → true
         */
        [DataTestMethod]
        [DataRow(-15, true, true)]
        [DataRow(-10, true, true)]
        [DataRow(-5, true, true)]
        [DataRow(0, true, true)]
        [DataRow(1, true, true)]
        [DataRow(2, true, false)]
        [DataRow(5, true, false)]
        [DataRow(9, true, false)]
        [DataRow(10, true, true)]
        [DataRow(11, true, true)]
        [DataRow(15, true, true)]
        [DataRow(20, true, true)]
        [DataRow(25, true, true)]
        [DataRow(-15, false, false)]
        [DataRow(-10, false, false)]
        [DataRow(-5, false, false)]
        [DataRow(0, false, false)]
        [DataRow(1, false, true)]
        [DataRow(2, false, true)]
        [DataRow(5, false, true)]
        [DataRow(9, false, true)]
        [DataRow(10, false, true)]
        [DataRow(11, false, false)]
        [DataRow(15, false, false)]
        [DataRow(20, false, false)]
        [DataRow(25, false, false)]
        public void In1To10(int ip1, bool ip2, bool op)
        {
            Assert.AreEqual(op, exercises.In1To10(ip1, ip2), $"Input: In1To10 ({ip1}, {ip2})");
        }

        /*
         SpecialEleven(22) → true
         SpecialEleven(23) → true
         SpecialEleven(24) → false
         */
        [DataTestMethod]
        [DataRow(0, true)]
        [DataRow(1, true)]
        [DataRow(2, false)]
        [DataRow(10, false)]
        [DataRow(11, true)]
        [DataRow(12, true)]
        [DataRow(13, false)]
        [DataRow(21, false)]
        [DataRow(22, true)]
        [DataRow(23, true)]
        [DataRow(24, false)]
        [DataRow(219, false)]
        [DataRow(220, true)]
        [DataRow(221, true)]
        [DataRow(222, false)]
        public void SpecialEleven(int ip1, bool op)
        {
            Assert.AreEqual(op, exercises.SpecialEleven(ip1), $"Input: SpecialEleven ({ip1})");
        }

        /*
         More20(20) → false
         More20(21) → true
         More20(22) → true
         */
        [DataTestMethod]
        [DataRow(0, false)]
        [DataRow(1, true)]
        [DataRow(2, true)]
        [DataRow(3, false)]
        [DataRow(19, false)]
        [DataRow(20, false)]
        [DataRow(21, true)]
        [DataRow(22, true)]
        [DataRow(23, false)]
        [DataRow(39, false)]
        [DataRow(40, false)]
        [DataRow(41, true)]
        [DataRow(42, true)]
        [DataRow(43, false)]
        [DataRow(399, false)]
        [DataRow(400, false)]
        [DataRow(401, true)]
        [DataRow(402, true)]
        [DataRow(403, false)]
        public void More20(int ip1, bool op)
        {
            Assert.AreEqual(op, exercises.More20(ip1), $"Input: More20 ({ip1})");
        }

        /*
         Old35(3) → true
         Old35(10) → true
         Old35(15) → false
         */
        [DataTestMethod]
        [DataRow(3, true)]
        [DataRow(10, true)]
        [DataRow(15, false)]
        [DataRow(6, true)]
        [DataRow(12, true)]
        [DataRow(21, true)]
        [DataRow(3, true)]
        [DataRow(6, true)]
        [DataRow(29, false)]
        [DataRow(23, false)]
        [DataRow(25, true)]
        [DataRow(7, false)]
        [DataRow(16, false)]
        [DataRow(17, false)]
        [DataRow(29, false)]
        [DataRow(11, false)]
        [DataRow(30, false)]
        [DataRow(5, true)]
        [DataRow(30, false)]
        [DataRow(20, true)]
        [DataRow(24, true)]
        [DataRow(37, false)]
        [DataRow(36, true)]
        [DataRow(9, true)]
        [DataRow(25, true)]
        [DataRow(40, true)]
        [DataRow(5, true)]
        [DataRow(25, true)]
        [DataRow(17, false)]
        [DataRow(47, false)]
        [DataRow(27, true)]
        [DataRow(48, true)]
        public void Old35(int ip1, bool op)
        {
            Assert.AreEqual(op, exercises.Old35(ip1), $"Input: Old35 ({ip1})");
        }

        /*
         Less20(18) → true
         Less20(19) → true
         Less20(20) → false
         */
        [DataTestMethod]
        [DataRow(0, false)]
        [DataRow(1, false)]
        [DataRow(17, false)]
        [DataRow(18, true)]
        [DataRow(19, true)]
        [DataRow(20, false)]
        [DataRow(21, false)]
        [DataRow(37, false)]
        [DataRow(38, true)]
        [DataRow(39, true)]
        [DataRow(40, false)]
        [DataRow(41, false)]
        [DataRow(397, false)]
        [DataRow(398, true)]
        [DataRow(399, true)]
        [DataRow(400, false)]
        [DataRow(401, false)]

        public void Less20(int ip, bool op)
        {
            Assert.AreEqual(op, exercises.Less20(ip), $"Input: Less20 ({ip})");
        }

        /*
         NearTen(12) → true
         NearTen(17) → false
         NearTen(19) → true
         */
        [DataTestMethod]
        [DataRow(0, true)]
        [DataRow(1, true)]
        [DataRow(2, true)]
        [DataRow(3, false)]
        [DataRow(7, false)]
        [DataRow(8, true)]
        [DataRow(9, true)]
        [DataRow(10, true)]
        [DataRow(11, true)]
        [DataRow(12, true)]
        [DataRow(13, false)]
        [DataRow(17, false)]
        [DataRow(18, true)]
        [DataRow(19, true)]
        [DataRow(20, true)]
        [DataRow(21, true)]
        [DataRow(22, true)]
        [DataRow(23, false)]
        [DataRow(197, false)]
        [DataRow(198, true)]
        [DataRow(199, true)]
        [DataRow(200, true)]
        [DataRow(201, true)]
        [DataRow(202, true)]
        [DataRow(203, false)]
        public void NearTen(int ip, bool op)
        {
            Assert.AreEqual(op, exercises.NearTen(ip), $"Input: NearTen ({ip})");
        }

        /*
         TeenSum(3, 4) → 7
         TeenSum(10, 13) → 19
         TeenSum(13, 2) → 19
         */
        [DataTestMethod]
        [DataRow(3, 4, 7)]
        [DataRow(10, 13, 19)]
        [DataRow(13, 2, 19)]
        [DataRow(-10, -8, -18)]
        [DataRow(-5, -8, -13)]
        [DataRow(-1, 34, 33)]
        [DataRow(0, -7, -7)]
        [DataRow(1, 28, 29)]
        [DataRow(5, 6, 11)]
        [DataRow(10, -6, 4)]
        [DataRow(12, 24, 36)]
        [DataRow(13, -1, 19)]
        [DataRow(14, -8, 19)]
        [DataRow(15, 34, 19)]
        [DataRow(16, 2, 19)]
        [DataRow(17, 4, 19)]
        [DataRow(18, 25, 19)]
        [DataRow(19, 6, 19)]
        [DataRow(20, 21, 41)]
        [DataRow(21, -2, 19)]
        [DataRow(25, -7, 18)]
        [DataRow(30, 28, 58)]
        [DataRow(35, 29, 64)]
        [DataRow(4, -10, -6)]
        [DataRow(7, -5, 2)]
        [DataRow(-5, -1, -6)]
        [DataRow(26, 0, 26)]
        [DataRow(32, 1, 33)]
        [DataRow(-10, 5, -5)]
        [DataRow(9, 10, 19)]
        [DataRow(28, 12, 40)]
        [DataRow(25, 13, 19)]
        [DataRow(31, 14, 19)]
        [DataRow(34, 15, 19)]
        [DataRow(29, 16, 19)]
        [DataRow(34, 17, 19)]
        [DataRow(6, 18, 19)]
        [DataRow(4, 19, 19)]
        [DataRow(33, 20, 53)]
        [DataRow(22, 21, 43)]
        [DataRow(11, 25, 36)]
        [DataRow(20, 30, 50)]
        [DataRow(24, 35, 59)]
        [DataRow(12, 12, 24)]
        [DataRow(13, 13, 19)]
        [DataRow(14, 14, 19)]
        [DataRow(15, 15, 19)]
        [DataRow(16, 16, 19)]
        [DataRow(17, 17, 19)]
        [DataRow(18, 18, 19)]
        [DataRow(19, 19, 19)]
        [DataRow(20, 20, 40)]
        public void TeenSum(int ip1, int ip2, int op)
        {
            Assert.AreEqual(op, exercises.TeenSum(ip1, ip2), $"Input: TeenSum ({ip1}, {ip2})");
        }

        /*
         AnswerCell(false, false, false) → true
         AnswerCell(false, false, true) → false
         AnswerCell(true, false, false) → false
         */
        [DataTestMethod]
        [DataRow(true, true, true, false)]
        [DataRow(true, true, false, true)]
        [DataRow(true, false, true, false)]
        [DataRow(true, false, false, false)]
        [DataRow(false, true, true, false)]
        [DataRow(false, true, false, true)]
        [DataRow(false, false, true, false)]
        [DataRow(false, false, false, true)]
        public void AnswerCell(bool ip1, bool ip2, bool ip3, bool op)
        {
            Assert.AreEqual(op, exercises.AnswerCell(ip1, ip2, ip3), $"Input: AnswerCell ({ip1}, {ip2}, {ip3})");
        }

        /*
         TeaParty(6, 8) → 1
         TeaParty(3, 8) → 0
         TeaParty(20, 6) → 2
         */
        [DataTestMethod]
        [DataRow(6, 8, 1)]
        [DataRow(3, 8, 0)]
        [DataRow(20, 6, 2)]
        [DataRow(8, 6, 1)]
        [DataRow(8, 3, 0)]
        [DataRow(6, 20, 2)]
        [DataRow(0, 1, 0)]
        [DataRow(4, 3, 0)]
        [DataRow(1, 3, 0)]
        [DataRow(2, 4, 0)]
        [DataRow(1, 0, 0)]
        [DataRow(3, 4, 0)]
        [DataRow(3, 1, 0)]
        [DataRow(4, 2, 0)]
        [DataRow(4, 4, 0)]
        [DataRow(5, 5, 1)]
        [DataRow(10, 10, 1)]
        [DataRow(8, 15, 1)]
        [DataRow(8, 16, 2)]
        [DataRow(8, 17, 2)]
        [DataRow(10, 19, 1)]
        [DataRow(10, 20, 2)]
        [DataRow(10, 21, 2)]
        [DataRow(15, 8, 1)]
        [DataRow(16, 8, 2)]
        [DataRow(17, 8, 2)]
        [DataRow(19, 10, 1)]
        [DataRow(20, 10, 2)]
        [DataRow(21, 10, 2)]
        public void TeaParty(int ip1, int ip2, int op)
        {
            Assert.AreEqual(op, exercises.TeaParty(ip1, ip2), $"Input: TeaParty ({ip1}, {ip2})");

        }

        /*
         TwoAsOne(1, 2, 3) → true
         TwoAsOne(3, 1, 2) → true
         TwoAsOne(3, 2, 2) → false
         */
        [DataTestMethod]
        [DataRow(28, -2, 26, true)]
        [DataRow(49, -57, -8, true)]
        [DataRow(7, -10, -3, true)]
        [DataRow(31, -27, 4, true)]
        [DataRow(20, -27, -7, true)]
        [DataRow(39, 16, -23, true)]
        [DataRow(23, 41, 18, true)]
        [DataRow(25, 43, 18, true)]
        [DataRow(43, 16, -27, true)]
        [DataRow(8, 46, 38, true)]
        [DataRow(-9, 29, 1, false)]
        [DataRow(23, 41, 39, false)]
        [DataRow(2, 14, 46, false)]
        [DataRow(14, 18, 15, false)]
        [DataRow(43, 19, 0, false)]
        [DataRow(48, 6, 18, false)]
        [DataRow(25, 46, 48, false)]
        [DataRow(-1, 21, 29, false)]
        [DataRow(48, 27, 31, false)]
        [DataRow(39, 33, 27, false)]
        [DataRow(13, 21, -7, false)]
        public void TwoAsOne(int ip1, int ip2, int ip3, bool op)
        {
            Assert.AreEqual(op, exercises.TwoAsOne(ip1, ip2, ip3), $"Input: TwoAsOne ({ip1}, {ip2}, {ip3})");
        }

        /*
         InOrder(1, 2, 4, false) → true
         InOrder(1, 2, 1, false) → false
         InOrder(1, 1, 2, true) → true
         */
        [TestMethod]
        [DataRow(1, 2, 4, false, true)]
        [DataRow(1, 2, 1, false, false)]
        [DataRow(1, 1, 2, true, true)]
        [DataRow(-10, 0, 10, true, true)]
        [DataRow(10, 20, 30, true, true)]
        [DataRow(20, 10, 30, true, true)]
        [DataRow(5, 5, 10, true, true)]
        [DataRow(5, -5, 6, true, true)]
        [DataRow(1, 2, 3, false, true)]
        [DataRow(-1, 0, 1, false, true)]
        [DataRow(5, 10, 15, false, true)]
        [DataRow(10, 11, 12, false, true)]
        [DataRow(1052, 2052, 3542, false, true)]
        [DataRow(-10, 0, 0, true, false)]
        [DataRow(10, 20, 20, true, false)]
        [DataRow(20, 10, 20, true, true)]
        [DataRow(20, 10, 10, true, false)]
        [DataRow(11, 12, 10, true, false)]
        [DataRow(10, 10, 10, false, false)]
        [DataRow(10, 10, 11, false, false)]
        [DataRow(11, 10, 9, false, false)]
        [DataRow(8, 4, 2, false, false)]
        [DataRow(-1052, -1053, -1054, false, false)]
        public void InOrder(int ip1, int ip2, int ip3, bool ip4, bool op)
        {
            Assert.AreEqual(op, exercises.InOrder(ip1, ip2, ip3, ip4), $"Input: InOrder ({ip1}, {ip2}, {ip3}, {ip4})");
        }

        /*
         InOrderEqual(2, 5, 11, false) → true
         InOrderEqual(5, 7, 6, false) → false
         InOrderEqual(5, 5, 7, true) → true
         */
        [DataTestMethod]
        [DataRow(2, 5, 11, false, true)]
        [DataRow(5, 7, 6, false, false)]
        [DataRow(5, 5, 7, true, true)]
        [DataRow(1, 2, 3, true, true)]
        [DataRow(-10, 0, 10, true, true)]
        [DataRow(10, 20, 20, true, true)]
        [DataRow(15, 15, 15, true, true)]
        [DataRow(15, 15, 20, true, true)]
        [DataRow(10, 20, 10, true, false)]
        [DataRow(10, 10, 5, true, false)]
        [DataRow(5, 5, -5, true, false)]
        [DataRow(3, 2, 1, true, false)]
        [DataRow(10, 5, 10, true, false)]
        [DataRow(2, 3, 4, false, true)]
        [DataRow(4, 8, 10, false, true)]
        [DataRow(-10, 0, 10, false, true)]
        [DataRow(50, 80, 81, false, true)]
        [DataRow(623, 982, 1236, false, true)]
        [DataRow(4, 4, 6, false, false)]
        [DataRow(-5, -5, 10, false, false)]
        [DataRow(5, 0, 0, false, false)]
        [DataRow(900, 300, 300, false, false)]
        [DataRow(50, 50, 50, false, false)]
        public void InOrderEqual(int ip1, int ip2, int ip3, bool ip4, bool op)
        {
            Assert.AreEqual(op, exercises.InOrderEqual(ip1, ip2, ip3, ip4), $"Input: InOrderEqual ({ip1}, {ip2}, {ip3}, {ip4})");
        }

        /*
         LoneSum(1, 2, 3) → 6
         LoneSum(3, 2, 3) → 2
         LoneSum(3, 3, 3) → 0
         */
        [DataTestMethod]
        [DataRow(1, 2, 3, 6)]
        [DataRow(3, 2, 3, 2)]
        [DataRow(3, 3, 3, 0)]
        [DataRow(6, 6, -10, -10)]
        [DataRow(-17, -17, 16, 16)]
        [DataRow(-8, -8, 9, 9)]
        [DataRow(11, 11, 9, 9)]
        [DataRow(-4, -4, 9, 9)]
        [DataRow(4, -3, 4, -3)]
        [DataRow(1, -1, 1, -1)]
        [DataRow(-9, -19, -9, -19)]
        [DataRow(-20, -18, -20, -18)]
        [DataRow(-1, -8, -1, -8)]
        [DataRow(-6, 11, -9, -4)]
        [DataRow(9, 6, 7, 22)]
        [DataRow(-13, -8, -16, -37)]
        [DataRow(15, -14, -1, 0)]
        [DataRow(-10, 15, -3, 2)]
        [DataRow(1, 1, 1, 0)]
        [DataRow(8, 8, 8, 0)]
        [DataRow(-2, -2, -2, 0)]
        [DataRow(2, 2, 2, 0)]
        [DataRow(6, 6, 6, 0)]
        [DataRow(19, -20, -20, 19)]
        [DataRow(10, -13, -13, 10)]
        [DataRow(8, 5, 5, 8)]
        [DataRow(-5, 14, 14, -5)]
        [DataRow(3, 6, 6, 3)]
        public void LoneSum(int ip1, int ip2, int ip3, int op)
        {
            Assert.AreEqual(op, exercises.LoneSum(ip1, ip2, ip3), $"Input: LoneSum ({ip1}, {ip2}, {ip3})");
        }

        /*
         LuckySum(1, 2, 3) → 6
         LuckySum(1, 2, 13) → 3
         LuckySum(1, 13, 3) → 1
         LuckySum(13, 1, 3) → 3
         LuckySum(13, 13, 3) → 0
         */
        [DataTestMethod]
        [DataRow(1, 2, 3, 6)]
        [DataRow(1, 2, 13, 3)]
        [DataRow(1, 13, 3, 1)]
        [DataRow(13, 1, 3, 3)]
        [DataRow(13, 13, 3, 0)]
        [DataRow(13, 13, 13, 0)]
        [DataRow(13, 13, 13, 0)]
        [DataRow(13, 13, 13, 0)]
        [DataRow(13, 13, 32, 0)]
        [DataRow(13, 13, -16, 0)]
        [DataRow(13, 13, 0, 0)]
        [DataRow(13, 37, 13, 0)]
        [DataRow(13, -11, 13, 0)]
        [DataRow(13, -19, 13, 0)]
        [DataRow(13, -3, 20, 20)]
        [DataRow(13, -12, -6, -6)]
        [DataRow(13, 16, -15, -15)]
        [DataRow(43, 13, 13, 43)]
        [DataRow(11, 13, 13, 11)]
        [DataRow(32, 13, 13, 32)]
        [DataRow(37, 13, 50, 37)]
        [DataRow(-8, 13, 46, -8)]
        [DataRow(23, 13, 47, 23)]
        [DataRow(6, -14, 13, -8)]
        [DataRow(40, 20, 13, 60)]
        [DataRow(5, 10, 13, 15)]
        [DataRow(33, 3, 6, 42)]
        [DataRow(19, 7, -8, 18)]
        [DataRow(30, 29, 14, 73)]
        public void LuckySum(int ip1, int ip2, int ip3, int op)
        {
            Assert.AreEqual(op, exercises.LuckySum(ip1, ip2, ip3), $"Input: LuckySum ({ip1}, {ip2}, {ip3})");
        }
    }
}