using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.PossibleState
{
    class WaitingState : IPossibleState
    {
        public void UpdateToDelivering(Order order)
        {
            Console.WriteLine("Update to delivering");
            order.CurrentState = new DeliveringState();
        }

        public void UpdateToDone(Order order)
        {
            Console.WriteLine("Update to done");
            order.CurrentState = new DoneState();
        }

        public void UpdateToProcessing(Order order)
        {
            Console.WriteLine("Update to processing");
            order.CurrentState = new ProcessingState();
        }

        public void UpdateToWaiting(Order order)
        {
            Console.WriteLine("Already in waiting");
        }

    }
}
