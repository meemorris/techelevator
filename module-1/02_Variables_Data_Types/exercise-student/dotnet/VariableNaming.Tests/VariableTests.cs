using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using System.Threading.Tasks;

namespace VariableNaming.Tests
{
    [TestClass]
    public class VariableTests
    {
        static List<Exercise> exercises = new List<Exercise>();

        private enum DataType { WholeNumber, Floating, String }
        private readonly string[] WholeNumberTypes = new string[] { "int" };
        private readonly string[] FloatingTypes = new string[] { "double", "decimal" };
        private readonly string[] StringTypes = new string[] { "string" };

        [ClassInitialize]
        static public void InitializeExercises(TestContext testContext) // The ClassInitialize method must be static...and should take a single parameter of type TestContext.
        {
            SyntaxAnalysis sa = new SyntaxAnalysis();
            exercises = sa.ParseExercises();
        }

        [TestMethod]
        public void Exercise_01()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 1);
            TestSuite(exercise, DataType.WholeNumber, 3);
        }

        [TestMethod]
        public void Exercise_02()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 2);
            TestSuite(exercise, DataType.WholeNumber, 3);
        }

        [TestMethod]
        public void Exercise_03()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 3);
            TestSuite(exercise, DataType.WholeNumber, 1);
        }

        [TestMethod]
        public void Exercise_04()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 4);
            TestSuite(exercise, DataType.WholeNumber, 2);
        }

        [TestMethod]
        public void Exercise_05()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 5);
            TestSuite(exercise, DataType.WholeNumber, 2);
        }

        [TestMethod]
        public void Exercise_06()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 6);
            TestSuite(exercise, DataType.WholeNumber, 5);
        }

        [TestMethod]
        public void Exercise_07()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 7);
            TestSuite(exercise, DataType.WholeNumber, 1);
        }

        [TestMethod]
        public void Exercise_08()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 8);
            TestSuite(exercise, DataType.WholeNumber, 3);
        }

        [TestMethod]
        public void Exercise_09()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 9);
            TestSuite(exercise, DataType.WholeNumber, 2);
        }

        [TestMethod]
        public void Exercise_10()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 10);
            TestSuite(exercise, DataType.Floating, 0.45);
        }

        [TestMethod]
        public void Exercise_11()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 11);
            TestSuite(exercise, DataType.WholeNumber, 55);
        }

        [TestMethod]
        public void Exercise_12()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 12);
            TestSuite(exercise, DataType.Floating, .38M);
        }

        [TestMethod]
        public void Exercise_13()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 13);
            TestSuite(exercise, DataType.WholeNumber, 18);
        }

        [TestMethod]
        public void Exercise_14()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 14);
            TestSuite(exercise, DataType.WholeNumber, 12);
        }

        [TestMethod]
        public void Exercise_15()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 15);
            TestSuite(exercise, DataType.Floating, 5);
        }

        [TestMethod]
        public void Exercise_16()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 16);
            TestSuite(exercise, DataType.WholeNumber, 9);
        }

        [TestMethod]
        public void Exercise_17()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 17);
            TestSuite(exercise, DataType.WholeNumber, 6);
        }

        [TestMethod]
        public void Exercise_18()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 18);
            TestSuite(exercise, DataType.WholeNumber, 9);
        }

        [TestMethod]
        public void Exercise_19()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 19);
            TestSuite(exercise, DataType.WholeNumber, 48);
        }

        [TestMethod]
        public void Exercise_20()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 20);
            TestSuite(exercise, DataType.WholeNumber, 48);
        }

        [TestMethod]
        public void Exercise_21()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 21);
            TestSuite(exercise, DataType.Floating, 1.98M);
        }

        [TestMethod]
        public void Exercise_22()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 22);
            TestSuite(exercise, DataType.WholeNumber, 61);
        }

        [TestMethod]
        public void Exercise_23()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 23);
            TestSuite(exercise, DataType.WholeNumber, 23);
        }

        [TestMethod]
        public void Exercise_24()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 24);
            TestSuite(exercise, DataType.WholeNumber, 46);
        }

        [TestMethod]
        public void Exercise_25()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 25);
            TestSuite(exercise, DataType.WholeNumber, 135);
        }

        [TestMethod]
        public void Exercise_26()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 26);
            TestSuite(exercise, DataType.Floating, 3.00M);
        }

        [TestMethod]
        public void Exercise_27()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 27);
            TestSuite(exercise, DataType.WholeNumber, 7);
        }

        [TestMethod]
        public void Exercise_28()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 28);
            TestSuite(exercise, DataType.WholeNumber, 13);
        }

        [TestMethod]
        public void Exercise_29()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 29);
            TestSuite(exercise, DataType.Floating, .46M);
        }

        [TestMethod]
        public void Exercise_30()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 30);
            TestSuite(exercise, DataType.WholeNumber, 25);
        }

        [TestMethod]
        public void Exercise_31()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 31);
            TestSuite(exercise, DataType.WholeNumber, 48);
        }

        [TestMethod]
        public void Exercise_32()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 32);
            TestSuite(exercise, DataType.WholeNumber, 20);
        }

        [TestMethod]
        public void Exercise_33()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 33);
            TestSuite(exercise, DataType.Floating, 2.00M);
        }

        [TestMethod]
        public void Exercise_34()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 34);
            TestSuite(exercise, DataType.WholeNumber, 15);
        }

        [TestMethod]
        public void Exercise_35()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 35);
            TestSuite(exercise, DataType.WholeNumber, 323);
        }

        [TestMethod]
        public void Exercise_36()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 36);
            TestSuite(exercise, DataType.WholeNumber, 48);
        }

        [TestMethod]
        public void Exercise_37()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 37);
            TestSuite(exercise, DataType.WholeNumber, 1110);
        }

        [TestMethod]
        public void Exercise_38()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 38);
            TestSuite(exercise, DataType.WholeNumber, 220);
        }

        [TestMethod]
        public void Exercise_39()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 39);
            TestSuite(exercise, DataType.Floating, 12);
        }

        [TestMethod]
        public void Exercise_40()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 40);
            TestSuite(exercise, DataType.WholeNumber, 5);
        }

        [TestMethod]
        public void Exercise_41()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 41);
            TestSuite(exercise, DataType.WholeNumber, 3);
        }

        [TestMethod]
        public void Exercise_42()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 42);
            TestSuite(exercise, DataType.WholeNumber, 23);
        }

        [TestMethod]
        public void Exercise_43()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 43);
            TestSuite(exercise, DataType.WholeNumber, 40);
        }

        [TestMethod]
        public void Exercise_44()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 44);
            TestSuite(exercise, DataType.WholeNumber, 17);
        }

        [TestMethod]
        public void Exercise_45()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 45);
            TestSuite(exercise, DataType.WholeNumber, 2);
        }

        [TestMethod]
        public void Exercise_46()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 46);
            TestSuite(exercise, DataType.WholeNumber, 14);
        }

        [TestMethod]
        public void Exercise_47()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 47);
            TestSuite(exercise, DataType.WholeNumber, 24);
        }

        [TestMethod]
        public void Exercise_48()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 48);
            TestSuite(exercise, DataType.WholeNumber, 6);
        }

        [TestMethod]
        public void Exercise_49()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 49);
            TestSuite(exercise, DataType.WholeNumber, 21);
        }

        [TestMethod]
        public void Exercise_50()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 50);
            TestSuite(exercise, DataType.Floating, 2.4285714285714284);
        }

        [TestMethod]
        public void Exercise_51()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 51);
            TestSuite(exercise, DataType.Floating, 5.0432098765432105);
        }

        [TestMethod]
        public void Exercise_52()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 52);
            TestSuite(exercise, DataType.String, "Hopper, Grace B.");
        }

        [TestMethod]
        public void Exercise_53()
        {
            Exercise exercise = exercises.FirstOrDefault(x => x.ExerciseId == 53);
            TestSuite(exercise, DataType.WholeNumber, 67);
        }


        // called by all exercises
        private void TestSuite(Exercise exercise, DataType dataType, object expectedValue)
        {
            Assert.IsTrue(AllVariablesCamelCased(exercise.VariableDeclarations), "Variables aren't in camelCase format.");
            Assert.IsTrue(exercise.VariableDeclarations.Count + exercise.ExpressionStatements.Count > 0, "You should use at least one variable to arrive at the answer. Try using variables to store values described in the problem.");
            Assert.IsTrue(LastVarIsCorrectType(exercise, dataType), "Make sure your final answer uses the most appropriate data type.");
            Assert.IsTrue(ReturnValueCorrect(exercise, expectedValue), "Final solution doesn't arrive at the correct answer.");
        }

        private bool AllVariablesCamelCased(IList<VariableDeclaration> varDecs)
        {
            Regex camelCase = new Regex(@"^[a-z]+((\d)|([A-Z0-9][a-z0-9]+))*([A-z]+)$");
            return varDecs.Where(vd => !vd.IsConstant).All(vd => camelCase.IsMatch(vd.VariableName));
        }

        private bool LastVarIsCorrectType(Exercise exercise, DataType acceptableType)
        {
            string lastVar = GetLastVarName(exercise);
            if (string.IsNullOrWhiteSpace(lastVar))
            {
                return false;
            }

            VariableDeclaration lastVarDec = exercise.VariableDeclarations.FirstOrDefault(vd => vd.VariableName == lastVar);
            switch (acceptableType)
            {
                case DataType.WholeNumber:
                    return WholeNumberTypes.Any(type => lastVarDec.DataType == type);
                case DataType.Floating:
                    return FloatingTypes.Any(type => lastVarDec.DataType == type);
                case DataType.String:
                    return StringTypes.Any(type => lastVarDec.DataType == type);
                default:
                    break;
            }
            return false;
        }

        private bool ReturnValueCorrect(Exercise exercise, object expectedValue)
        {
            string lastVar = GetLastVarName(exercise);

            if (string.IsNullOrWhiteSpace(lastVar))
            {
                return false;
            }

            //execute student code block
            var codeResult = Task.Run(async () => {
                var s = await CSharpScript.RunAsync(exercise.OriginalCodeBlock + lastVar); //appending lastVar will return the value of the variable
                return s.ReturnValue;
            }).Result;

            //call object.ToString() so comparison is valid
            return codeResult.ToString() == expectedValue.ToString();
        }

        private string GetLastVarName(Exercise exercise)
        {
            //get last variable used
            int maxSpanVar = exercise.VariableDeclarations.Count > 0 ? exercise.VariableDeclarations.Max(v => v.SpanStart) : -1;
            int maxSpanExp = exercise.ExpressionStatements.Count > 0 ? exercise.ExpressionStatements.Max(v => v.SpanStart) : -1;

            string lastVar = string.Empty;
            if (maxSpanVar > maxSpanExp)
            {
                VariableDeclaration declaration = exercise.VariableDeclarations.FirstOrDefault(v => v.SpanStart == maxSpanVar);
                lastVar = declaration.VariableName;
            }
            if (maxSpanExp > maxSpanVar)
            {
                ExpressionStatement statement = exercise.ExpressionStatements.FirstOrDefault(v => v.SpanStart == maxSpanExp);
                lastVar = statement.AssignTo;
            }

            return lastVar;
        }
    }
}
