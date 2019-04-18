using System;
using System.Collections.Generic;
using System.Text;
using KeyJoinConstruction.Tree;

namespace KeyJoinConstruction.Operator
{
    class AndOperator : BinaryOperator
    {
        public int Precedence { get { return 20; } }

        public AndOperator()
        {
            this.Name = "AND";
        }

        public override bool Evaluate()
        {
            this.Value = this.LeftOperator.Evaluate() && this.RightOperator.Evaluate();
            return this.Value.Value;
        }
    }
}
