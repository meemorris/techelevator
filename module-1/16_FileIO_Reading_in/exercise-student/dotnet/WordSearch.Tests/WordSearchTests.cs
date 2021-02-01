using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace WordSearch.Tests
{
    [TestClass]
    public class WordSearchTests
    {
        private static string testTextFile;
        private const string wordToSearch = "between";

        [ClassInitialize]
        static public void Initialize(TestContext testContext) // The ClassInitialize method must be static...and should take a single parameter of type TestContext.
        {
            string currDir = Environment.CurrentDirectory;
            string mainProjDir = Directory.GetParent(currDir).Parent.Parent.Parent.FullName;
            mainProjDir = mainProjDir.Replace("\\", "/");
            testTextFile = $"{mainProjDir}/WordSearch.Tests/dr_jekyll_mr_hyde.txt";
        }

        [TestMethod]
        public void CaseInsensitiveSearch_LineNumbers()
        {
            string input = testTextFile + Environment.NewLine + wordToSearch + Environment.NewLine + "n";
            StringBuilder output = new StringBuilder();

            using (var reader = new StringReader(input))
            using (var writer = new StringWriter(output))
            {
                Console.SetIn(reader);
                Console.SetOut(writer);
                Program.Main(null);
            }

            string[] returnedLines = output.ToString().Trim().Split(Environment.NewLine);
            IEnumerable<string> linesStartWithNumber = returnedLines.Where(line => Regex.IsMatch(line, @"^\d+"));

            if (linesStartWithNumber.Count() == 0)
            {
                Assert.Fail("No line numbers found.");
            }

            int[] expectedLineNumbers = new int[] { 769, 958, 987, 2294, 2296, 2373 };

            int i = 0;
            foreach (string line in linesStartWithNumber)
            {
                string lineNumber = Regex.Match(line, @"^\d+").ToString();

                //if parse fails, or parsed number doesn't matched expected
                if (!int.TryParse(lineNumber, out int parsedLineNumber) || parsedLineNumber != expectedLineNumbers[i])
                {
                    Assert.Fail("Line number doesn't match expected value.");
                }

                i++;
            }
        }

        [TestMethod]
        public void CaseInsensitiveSearch_LineText()
        {
            string input = testTextFile + Environment.NewLine + wordToSearch + Environment.NewLine + "n";
            StringBuilder output = new StringBuilder();

            using (var reader = new StringReader(input))
            using (var writer = new StringWriter(output))
            {
                Console.SetIn(reader);
                Console.SetOut(writer);
                Program.Main(null);
            }

            string[] expectedLineText = new string[] {  "daylight would glance in between the swirling wreaths. The dismal",
                                                        "his head clerk, upon the other, and midway between, at a nicely",
                                                        "document here in his handwriting; it is between ourselves, for I scarce",
                                                        "Between these two, I now felt I had to choose. My two natures had",
                                                        "between them. Jekyll (who was composite) now with the most sensitive",
                                                        "me; and still, between the petitions, the ugly face of my iniquity" };

            string[] returnedLines = output.ToString().Trim().Split(Environment.NewLine);
            string firstItem = returnedLines.FirstOrDefault(rl => rl.Contains(expectedLineText[0]));
            int firstItemIndex = Array.IndexOf(returnedLines, firstItem);

            if (firstItemIndex == -1)
            {
                Assert.Fail("First expected line not found.");
            }

            int i = 0;
            foreach (string line in returnedLines.Skip(firstItemIndex))
            {
                if (!line.Trim().Contains(expectedLineText[i]))
                {
                    Assert.Fail("Line text doesn't match expected value");
                }

                i++;
            }
        }

        [TestMethod]
        public void CaseSensitiveSearch_LineNumbers()
        {
            string input = testTextFile + Environment.NewLine + wordToSearch + Environment.NewLine + "y";
            StringBuilder output = new StringBuilder();

            using (var reader = new StringReader(input))
            using (var writer = new StringWriter(output))
            {
                Console.SetIn(reader);
                Console.SetOut(writer);
                Program.Main(null);
            }

            int[] expectedLineNumbers = new int[] { 769, 958, 987, 2296, 2373 };

            string[] returnedLines = output.ToString().Trim().Split(Environment.NewLine);
            IEnumerable<string> linesStartWithNumber = returnedLines.Where(line => Regex.IsMatch(line, @"^\d+"));

            if (linesStartWithNumber.Count() == 0)
            {
                Assert.Fail("No line numbers found.");
            }

            int i = 0;
            foreach (string line in linesStartWithNumber)
            {
                string lineNumber = Regex.Match(line, @"^\d+").ToString();

                //if parse fails, or parsed number doesn't matched expected
                if (!int.TryParse(lineNumber, out int parsedLineNumber) || parsedLineNumber != expectedLineNumbers[i])
                {
                    Assert.Fail("Line number doesn't match expected value.");
                }

                i++;
            }
        }

        [TestMethod]
        public void CaseSensitiveSearch_LineText()
        {
            string input = testTextFile + Environment.NewLine + wordToSearch + Environment.NewLine + "y";
            StringBuilder output = new StringBuilder();

            using (var reader = new StringReader(input))
            using (var writer = new StringWriter(output))
            {
                Console.SetIn(reader);
                Console.SetOut(writer);
                Program.Main(null);
            }

            string[] expectedLineText = new string[] {  "daylight would glance in between the swirling wreaths. The dismal",
                                                        "his head clerk, upon the other, and midway between, at a nicely",
                                                        "document here in his handwriting; it is between ourselves, for I scarce",
                                                        "between them. Jekyll (who was composite) now with the most sensitive",
                                                        "me; and still, between the petitions, the ugly face of my iniquity" };

            string[] returnedLines = output.ToString().Trim().Split(Environment.NewLine);
            string firstItem = returnedLines.FirstOrDefault(rl => rl.Contains(expectedLineText[0]));
            int firstItemIndex = Array.IndexOf(returnedLines, firstItem);

            if (firstItemIndex == -1)
            {
                Assert.Fail("First expected line not found.");
            }

            int i = 0;
            foreach (string line in returnedLines.Skip(firstItemIndex))
            {
                if (!line.Trim().Contains(expectedLineText[i]))
                {
                    Assert.Fail("Line text doesn't match expected value");
                }

                i++;
            }
        }
    }
}
