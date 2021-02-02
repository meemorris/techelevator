using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace FileIOPart2.Tests
{
    [TestClass]
    public class FindAndReplaceTests
    {
        private static string mainProjDir;
        private static string testSourceFile;
        private static string testDestFile;

        [ClassInitialize]
        static public void Initialize(TestContext testContext) // The ClassInitialize method must be static...and should take a single parameter of type TestContext.
        {
            var currDir = Environment.CurrentDirectory;
            mainProjDir = Directory.GetParent(currDir).Parent.Parent.Parent.FullName;
            mainProjDir = mainProjDir.Replace("\\", "/");
            testSourceFile = $"{mainProjDir}/FileIOPart2.Tests/bacon.txt";
            testDestFile = $"{mainProjDir}/FileIOPart2.Tests/bacon_replace.txt";
        }

        [TestMethod]
        public void ShouldReplaceNoOccurrences()
        {
            string searchWord = "spinach";
            string replaceWord = "tofu";

            RunProgram(searchWord, replaceWord);

            Assert.IsTrue(File.Exists(testDestFile));

            string srcContent = File.ReadAllText(testSourceFile);
            string destContent = File.ReadAllText(testDestFile);

            string expectedContent = srcContent.Replace(searchWord, replaceWord);

            Assert.AreEqual(expectedContent.Trim(), destContent.Trim(), "Expected output does not equal actual output.");

            // delete test output file
            if (File.Exists(testDestFile))
            {
                File.Delete(testDestFile);
            }
        }

        [TestMethod]
        public void ShouldReplaceOneOccurrence()
        {
            string searchWord = "Bacon";
            string replaceWord = "tofu";

            RunProgram(searchWord, replaceWord);

            Assert.IsTrue(File.Exists(testDestFile));

            string srcContent = File.ReadAllText(testSourceFile);
            string destContent = File.ReadAllText(testDestFile);

            string expectedContent = srcContent.Replace(searchWord, replaceWord);

            Assert.AreEqual(expectedContent.Trim(), destContent.Trim(), "Expected output does not equal actual output.");

            // delete test output file
            if (File.Exists(testDestFile))
            {
                File.Delete(testDestFile);
            }
        }

        [TestMethod]
        public void ShouldReplaceMultipleOccurrences()
        {
            string searchWord = "bacon";
            string replaceWord = "tofu";

            RunProgram(searchWord, replaceWord);

            Assert.IsTrue(File.Exists(testDestFile));

            string srcContent = File.ReadAllText(testSourceFile);
            string destContent = File.ReadAllText(testDestFile);

            string expectedContent = srcContent.Replace(searchWord, replaceWord);

            Assert.AreEqual(expectedContent.Trim(), destContent.Trim(), "Expected output does not equal actual output.");

            // delete test output file
            if (File.Exists(testDestFile))
            {
                File.Delete(testDestFile);
            }
        }

        private void RunProgram(string searchWord, string replaceWord)
        {
            string input = searchWord + Environment.NewLine + replaceWord + Environment.NewLine + testSourceFile + Environment.NewLine + testDestFile;

            using (var reader = new StringReader(input))
            {
                Console.SetIn(reader);
                FindAndReplace.Program.Main(null);
            }
        }
    }
}
