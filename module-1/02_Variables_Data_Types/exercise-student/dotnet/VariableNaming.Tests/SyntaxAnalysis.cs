using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VariableNaming.Tests
{
    class SyntaxAnalysis
    {
        private string programText = string.Empty;
        private readonly string folderToFind = "VariableNaming";
        private readonly string fileToFind = "Program.cs";

        public SyntaxAnalysis()
        {
            //C#
            //read in Program.cs from main project
            using StreamReader sr = new StreamReader(GetProgramCs());
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();

                //single line comments seem throw off the analyzer, so strip them out
                if (line.Trim().StartsWith("//"))
                    continue;
                if (line.Contains("//")) //trim off any comments that might be at the end of a line
                    line = line.Substring(0, line.IndexOf("//"));

                programText += line.Trim();
            }
            //END C#

            ////JAVA
            ////read in Exercises.java
            //Regex float_regex = new Regex(@"[0-9]+f");

            //using StreamReader sr = new StreamReader(GetExerciseJava());
            //while (!sr.EndOfStream)
            //{
            //    string line = sr.ReadLine();

            //    //single line comments seem throw off the analyzer, so strip them out
            //    if (line.Trim().StartsWith("//"))
            //        continue;
            //    if (line.Contains("//")) //trim off any comments that might be at the end of a line
            //        line = line.Substring(0, line.IndexOf("//"));

            //    if (line.Contains("package com."))
            //    {
            //        line = "namespace techelevator {";
            //    }
            //    if (float_regex.IsMatch(line))
            //    {
            //        MatchCollection matches = float_regex.Matches(line);
            //        foreach (Match match in matches)
            //        {
            //            line = line.Replace(match.Value, match.Value.Replace("f", "M"));
            //        }
            //        int fIndex = line.IndexOf("f");
            //        int fCount = line.Count(x => x == 'f');
            //    }
            //    line = line.Replace("float", "decimal").Replace("final", "const").Replace("String", "string").Replace("public static void main", "public static void Main");

            //    programText += line.Trim();
            //}
            //if (!string.IsNullOrWhiteSpace(programText))
            //{
            //    programText += "}"; //close namespace
            //}
            ////END JAVA
        }

        public List<Exercise> ParseExercises()
        {
            List<Exercise> exercises = new List<Exercise>();

            //drill down to main method
            SyntaxTree tree = CSharpSyntaxTree.ParseText(programText);
            CompilationUnitSyntax root = tree.GetCompilationUnitRoot();
            MemberDeclarationSyntax firstMember = root.Members[0];
            var helloWorldDeclaration = (NamespaceDeclarationSyntax)firstMember;
            var programDeclaration = (ClassDeclarationSyntax)helloWorldDeclaration.Members[0];
            var mainDeclaration = (MethodDeclarationSyntax)programDeclaration.Members[0];

            //get code block from main, and parse exercises and comments
            var codeBlock = mainDeclaration.ChildNodes().FirstOrDefault(n => n.Kind().ToString() == "Block");
            if (codeBlock != null)
            {
                var commentNodes = codeBlock.DescendantTrivia().Where(t => t.Kind().ToString() == "MultiLineCommentTrivia" && !t.ToFullString().Contains("CHALLENGE PROBLEMS")).ToArray();
                var variableNodes = codeBlock.ChildNodes();

                //parse comments to get exercise IDs, and location of student code (CommentSpanEnd and NextCommentSpanStart)
                //also create the Exercise objects for the `exercises` List.
                for (int c = 0; c < commentNodes.Length; c++)
                {
                    var commentNode = commentNodes[c];
                    string commentTrimmed = commentNode.ToString().Replace("/*", "").Trim();
                    Regex number_regex = new Regex(@"^[0-9]+$");

                    if (number_regex.IsMatch(commentTrimmed.Substring(0, 1)) && commentTrimmed.Substring(0, 3).Contains("."))
                    {
                        string strExerciseId = commentTrimmed.Substring(0, commentTrimmed.IndexOf("."));
                        if (int.TryParse(strExerciseId, out int exerciseId))
                        {
                            exercises.Add(new Exercise()
                            {
                                ExerciseId = exerciseId,
                                CommentSpanEnd = commentNode.Span.End,
                            });

                            if (exercises.Count > 1)
                            {
                                //NextCommentSpanStart is used to determine where the student code for this exercise ends
                                exercises[c - 1].NextCommentSpanStart = commentNode.Span.Start;
                            }
                        }
                    }

                    exercises.Last().NextCommentSpanStart = int.MaxValue;
                }

                //get the student code foreach exercise (created in loop above)
                foreach (var ex in exercises)
                {
                    //student code between CommentSpanEnd and NextCommentSpanStart
                    var vars = variableNodes.Where(v => v.Span.Start >= ex.CommentSpanEnd
                                                     && v.Span.End <= ex.NextCommentSpanStart);

                    foreach (var v in vars)
                    {
                        ex.OriginalCodeBlock += v.ToString();

                        if (v.GetType() == typeof(LocalDeclarationStatementSyntax)) // like `int x = 3`
                        {
                            var declaration = ((LocalDeclarationStatementSyntax)v).Declaration;

                            ex.VariableDeclarations.Add(new VariableDeclaration()
                            {
                                DataType = declaration.Type.ToString(),
                                VariableName = declaration.Variables.FirstOrDefault().Identifier.Value.ToString(),
                                InitialValue = declaration.Variables.FirstOrDefault().Initializer.Value.ToString(),
                                SpanStart = declaration.SpanStart,
                                IsConstant = ((LocalDeclarationStatementSyntax)v).IsConst
                            });
                        }

                        if (v.GetType() == typeof(ExpressionStatementSyntax) && // like `x = a + b`
                           ((ExpressionStatementSyntax)v).Expression.GetType() == typeof(AssignmentExpressionSyntax)) //must be like `x = a + b`; ignore other code like `Console.WriteLine(x)`
                        {
                            var expression = (AssignmentExpressionSyntax)((ExpressionStatementSyntax)v).Expression;
                            ex.ExpressionStatements.Add(new ExpressionStatement()
                            {
                                AssignTo = expression.Left.ToString(),
                                AssignValue = expression.Right.ToString(),
                                SpanStart = expression.SpanStart
                            });
                        }
                    }
                }
            }

            return exercises;
        }

        private string GetExerciseJava()
        {
            //TODO make dynamic
            return "C:/Users/Student/source/repos/te-curriculum/module-1/02_Variables_Data_Types/exercise-final/java/src/main/java/com/techelevator/Exercises.java";
        }

        private string GetProgramCs()
        {
            string currPath = Environment.CurrentDirectory;
            string progPath = string.Empty;

            if (currPath.Contains("\\"))
            {
                currPath = currPath.Replace("\\", "/");
            }

            while (string.IsNullOrEmpty(progPath))
            {
                if (Directory.GetDirectories(currPath).Any(d => d.EndsWith(folderToFind)))
                {
                    currPath = Directory.GetDirectories(currPath).FirstOrDefault(d => d.EndsWith(folderToFind));
                    if (Directory.GetFiles(currPath).Any(f => f.EndsWith(fileToFind)))
                    {
                        progPath = Directory.GetFiles(currPath).FirstOrDefault(f => f.EndsWith(fileToFind));
                        break;
                    }
                }
                else
                {
                    if (currPath == "C:") //ran out of locations to check
                    {
                        break;
                    }

                    //go up one level
                    currPath = currPath.Substring(0, currPath.LastIndexOf("/"));
                }
            }

            return progPath;
        }
    }
}
