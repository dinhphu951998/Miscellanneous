using KeyJoinConstruction.Operator;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeyJoinConstruction.Tree
{
    class TreeNode
    {
        public BaseOperator Expression { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
        public bool? Result { get; set; }

        public bool Evaluate()
        {
            if (Result == null)
            {
                Result = this.Expression.Evaluate();
            }
            return this.Result.Value;
        }

    }
}
