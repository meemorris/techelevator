using System.Collections.Generic;

namespace VariableNaming.Tests
{
    class Exercise
    {
        public int ExerciseId { get; set; }
        public int CommentSpanEnd { get; set; }
        public int NextCommentSpanStart { get; set; } // used to determine where the student code for this exercise ends
        public List<VariableDeclaration> VariableDeclarations { get; set; } = new List<VariableDeclaration>();
        public List<ExpressionStatement> ExpressionStatements { get; set; } = new List<ExpressionStatement>();
        public string OriginalCodeBlock { get; set; } // for unit test evaluation
    }

    class VariableDeclaration
    {
        public string DataType { get; set; }
        public string VariableName { get; set; }
        public object InitialValue { get; set; }
        public int SpanStart { get; set; }
        public bool IsConstant { get; set; }
    }

    class ExpressionStatement
    {
        public string AssignTo { get; set; }
        public string AssignValue { get; set; }
        public int SpanStart { get; set; }
    }
}
