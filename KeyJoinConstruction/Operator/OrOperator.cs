using System;
using System.Collections.Generic;
using System.Text;
using KeyJoinConstruction.Tree;

namespace KeyJoinConstruction.Operator
{
    class OrOperator : BinaryOperator
    {
        public int Precedence { get { return 10; } }

        public OrOperator()
        {
            this.Name = "OR";
        }

        public override bool Evaluate()
        {
            this.Value = this.LeftOperator.Evaluate() || this.RightOperator.Evaluate();
            return this.Value.Value;
        }
    }
}
