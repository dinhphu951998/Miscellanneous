using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternWithJavaStyle
{
    abstract class Context
    {
        public abstract void SetState(PossibleState state);
    }
}
