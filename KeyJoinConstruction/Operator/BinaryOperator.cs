using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace KeyJoinConstruction.Operator
{
    class BinaryOperator : BaseOperator
    {
        public BaseOperator RightOperator { get; set; }
        public BaseOperator LeftOperator { get; set; }
    }
}
