using System;
using System.Collections.Generic;
using System.Text;


namespace StatePatternWithJavaStyle
{
    class DoneState : State
    {
        public override void Handle(Context context)
        {
            Console.WriteLine("The order has already completed.");
            base.Handle(context);
        }
    }
}
