using StatePatternWithJavaStyle;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternWithJavaStyle
{
    abstract class State
    {
        public virtual void Handle(Context context)
        {
            context.SetState(this);
        }
    }

}
