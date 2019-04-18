using KeyJoinConstruction.Tree;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeyJoinConstruction.Operator
{
    class BaseOperator
    {
        public string Name { get; set; }
        public bool? Value { get; set; }

        public virtual bool Evaluate()
        {
            return this.Value.Value;
        }

    }



}
