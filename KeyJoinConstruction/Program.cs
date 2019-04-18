using KeyJoinConstruction.Operator;
using KeyJoinConstruction.Tree;
using System;
using System.Collections.Generic;

namespace KeyJoinConstruction
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = TreeBuilder.Build(KeyJoin);
            bool result = tree.Root.Evaluate();
            Console.WriteLine(result);
            Console.Read();
        }

        public static List<Relationship> KeyJoin = new List<Relationship>()
        {
            new Relationship()
            {
                Value = true //A
            },
            new Relationship()
            {
                OperatorName = "AND",
                Value = false //B
            },
            new Relationship()
            {
                OperatorName = "OR",
                Value = false //C
            },
            new Relationship()
            {
                OperatorName = "AND",
                Value = true //D
            },
            new Relationship()
            {
                OperatorName = "AND",
                Value = true //E
            },
            new Relationship()
            {
                OperatorName = "OR",
                Value = false, //F
                UnaryOperator = "NOT"
            },
            new Relationship()
            {
                OperatorName = "OR",
                Value = true, //G
                UnaryOperator = "NOT"
            }
        };
    }

    class Relationship
    {
        public string OperatorName { get; set; }
        public bool? Value { get; set; }
        public string UnaryOperator { get; set; } 
    }
}
