using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace FileIOPart2.Tests
{
    [TestClass]
    public class FizzWriterTests
    {
        private static string mainProjDir;
        private static string testDestFile;
        private static string testExpectedFile;

        [ClassInitialize]
        static public void Initialize(TestContext testContext) // The ClassInitialize method must be static...and should take a single parameter of type TestContext.
        {
            var currDir = Environment.CurrentDirectory;
            mainProjDir = Directory.GetParent(currDir).Parent.Parent.Parent.FullName;
            mainProjDir = mainProjDir.Replace("\\", "/");
            testDestFile = $"{mainProjDir}/FileIOPart2.Tests/fizz_output.txt";
            testExpectedFile = $"{mainProjDir}/FileIOPart2.Tests/fizzbuzz_expected.txt";
        }

        [TestMethod]
        public void FizzBuzz_ShouldEqualExpectedOutput()
        {
            RunProgram();

            Assert.IsTrue(File.Exists(testDestFile), "File was not created.");

            string destContent = File.ReadAllText(testDestFile);
            string expectedContent = File.ReadAllText(testExpectedFile);

            Assert.AreEqual(expectedContent.Trim(), destContent.Trim(), "Expected output does not equal actual output.");

            // delete test output file
            if (File.Exists(testDestFile))
            {
                File.Delete(testDestFile);
            }
        }

        [TestMethod]
        public void DestinationFile_ShouldHaveThreeHundredLines()
        {
            RunProgram();

            Assert.IsTrue(File.Exists(testDestFile), "File was not created.");

            string[] destContent = File.ReadAllLines(testDestFile);

            Assert.AreEqual(300, destContent.Length, "Expected line count does not equal actual line count.");

            // delete test output file
            if (File.Exists(testDestFile))
            {
                File.Delete(testDestFile);
            }
        }

        private void RunProgram()
        {
            string input = testDestFile;

            using (var reader = new StringReader(input))
            {
                Console.SetIn(reader);
                FizzWriter.Program.Main(null);
            }
        }
    }
}
