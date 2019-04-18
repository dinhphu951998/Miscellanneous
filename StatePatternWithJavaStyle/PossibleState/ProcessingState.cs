using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternWithJavaStyle
{
    class ProcessingState : State
    {

        public override void Handle(Context context)
        {
            Console.WriteLine("The order is marked by ADMIN. We will try to delivery as soon as possible");
            base.Handle(context);
        }
    }
}
