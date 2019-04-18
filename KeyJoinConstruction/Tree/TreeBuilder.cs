using KeyJoinConstruction.Operator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace KeyJoinConstruction.Tree
{
    class TreeBuilder
    {
        public BaseOperator Root { get; set; }
        public TreeBuilder()
        {
        }

        private TreeNode GetTheLastNode(TreeNode root)
        {
            //Get last left or right đều được
            return GetTheLastNode(root.Left);
        }

        public bool EvaluateExpression(TreeNode node)
        {
            if (node.Left == null && node.Right == null)
            {

            }


            return false;
        }

        public static TreeBuilder Build(List<Relationship> relationshipKeyJoins)
        {
            TreeBuilder tree = new TreeBuilder();
            tree.Root = BuildBranch(relationshipKeyJoins);
            return tree;
        }

        private static BaseOperator BuildBranch(List<Relationship> relationshipKeyJoins)
        {
            List<BaseOperator> operators = CreateListOperator(relationshipKeyJoins);
            GroupByNot(operators);
            GroupByAnd(operators);
            GroupByOr(operators);
            return operators.FirstOrDefault();
        }

        public static List<BaseOperator> CreateListOperator(List<Relationship> relationshipKeyJoins)
        {
            var operators = new List<BaseOperator>();
            var factory = new OperatorFactory();

            relationshipKeyJoins.ForEach(join =>
            {
                if(join.OperatorName != null)
                {
                    operators.Add(factory.CreateOperator(join.OperatorName));
                }
                if (join.UnaryOperator != null)
                {
                    operators.Add(factory.CreateOperator(join.UnaryOperator));
                }
                if (join.Value.HasValue)
                {
                    operators.Add(factory.CreateValueOperator(join.Value.Value));
                }
            });
            return operators;
        }

        public static void GroupByNot(List<BaseOperator> operators)
        {
            var notOperators = operators.Where(o => o.Name == "NOT").ToList();
            notOperators.ForEach(o =>
           {
               int index = operators.IndexOf(o);
               var n = o as NotOperator;

               //assign child for not
               n.ChildOperator = operators[index + 1];

               //remove child operators from the list
               operators.RemoveAt(index + 1);
           });
        }

        public static void GroupByAnd(List<BaseOperator> operators)
        {
            var andOperators = operators.Where(o => o.Name == "AND").ToList();
            andOperators.ForEach(o =>
            {
                int index = operators.IndexOf(o);
                var a = o as AndOperator;

                //assign child for not
                a.LeftOperator = operators[index - 1];
                a.RightOperator = operators[index + 1];

                //remove child operators from the list
                operators.RemoveAt(index + 1);
                operators.RemoveAt(index - 1);
            });
        }

        public static void GroupByOr(List<BaseOperator> operators)
        {
            var orOperators = operators.Where(o => o.Name == "OR").ToList();
            orOperators.ForEach(o =>
            {
                int index = operators.IndexOf(o);
                var or = o as OrOperator;

                //assign child for not
                or.LeftOperator = operators[index - 1];
                or.RightOperator = operators[index + 1];

                //remove child operators from the list
                operators.RemoveAt(index + 1);
                operators.RemoveAt(index - 1);
            });
        }


        //private static TreeNode BuildBranch(List<BaseOperator> relationshipKeyJoins, int index)
        //{
        //    TreeNode node = null;
        //    if (relationshipKeyJoins != null && relationshipKeyJoins.Count > index)
        //    {
        //        node = new TreeNode();
        //        var keyJoin = relationshipKeyJoins[index];
        //        node.Expression = keyJoin;

        //        //var nextKeyJoin = relationshipKeyJoins[index + 1];
        //        if (keyJoin.Name.Equals("AND"))
        //        {
        //            node.Left = new TreeNode()
        //            {
        //                Result = true
        //            };
        //        }
        //        node.Right = BuildBranch(relationshipKeyJoins, index + 1);
        //    }
        //    return node;
        //}



    }
}
