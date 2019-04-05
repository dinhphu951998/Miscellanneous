using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.PossibleState
{
    interface IPossibleState
    {
        void UpdateToWaiting(Order order);
        void UpdateToProcessing(Order order);
        void UpdateToDelivering(Order order);
        void UpdateToDone(Order order);

    }
}
