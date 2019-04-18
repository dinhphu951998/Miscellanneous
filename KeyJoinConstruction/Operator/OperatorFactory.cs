using System;
using System.Collections.Generic;
using System.Text;

namespace KeyJoinConstruction.Operator
{
    class OperatorFactory
    {
        public BaseOperator CreateOperator(string name)
        {
            switch (name)
            {
                case "AND":
                    return new AndOperator();
                case "OR":
                    return new OrOperator();
                case "NOT":
                    return new NotOperator();
            }
            return null;
        }

        public BaseOperator CreateValueOperator(bool value)
        {
            return new BaseOperator()
            {
                Value = value
            };
        }

    }
}
