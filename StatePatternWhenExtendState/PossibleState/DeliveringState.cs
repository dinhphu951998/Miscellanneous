using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.PossibleState
{
    class DeliveringState : IPossibleState
    {
        public void UpdateToDelivering(Order order)
        {
            Console.WriteLine("Already in delivering");
        }

        public void UpdateToDone(Order order)
        {
            Console.WriteLine("Update to done");
            order.CurrentState = new DoneState();
        }

        public void UpdateToProcessing(Order order)
        {
            Console.WriteLine("Update back to processing");
            order.CurrentState = new ProcessingState();
        }

        public void UpdateToWaiting(Order order)
        {
            Console.WriteLine("Update back to waiting");
            order.CurrentState = new WaitingState();
        }


    }
}
