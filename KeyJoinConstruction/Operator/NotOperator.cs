using System;
using System.Collections.Generic;
using System.Text;

namespace KeyJoinConstruction.Operator
{
    class NotOperator : UnaryOperator
    {
        public int Precedence { get { return 30; } }

        public NotOperator()
        {
            this.Name = "NOT";
        }

        public override bool Evaluate()
        {
            this.Value = !this.ChildOperator.Evaluate();
            return this.Value.Value;
        }
    }
}
