using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace KeyJoinConstruction.Operator
{
    class UnaryOperator : BaseOperator
    {
        public BaseOperator ChildOperator { get; set; }
    }
}
