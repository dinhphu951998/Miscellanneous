using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternWithJavaStyle
{
    class WaitingState : State
    {
        public override void Handle(Context context)
        {
            Console.WriteLine("Please wait for us. We are trying to verify your order.");
            base.Handle(context);
        }

    }
}
