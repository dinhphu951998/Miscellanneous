using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternWithJavaStyle
{
    class DeliveringState : State
    {
        public override void Handle(Context context)
        {
            Console.WriteLine("Your product has been in delivery");
            base.Handle(context);
        }
    }
}
