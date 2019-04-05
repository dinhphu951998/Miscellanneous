using StatePattern.PossibleState;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class OrderStatePool
    {
        private static WaitingState waiting;
        private static ProcessingState processing;
        private static DeliveringState delivering;
        private static DoneState done;


        public static IPossibleState GetWaitingStateInstance()
        {
            if (waiting == null)
            {
                waiting = new WaitingState();
            }
            return waiting;
        }

        public static IPossibleState GetProcessingStateInstance()
        {
            if (processing == null)
            {
                processing = new ProcessingState();
            }
            return processing;
        }
        public static IPossibleState GetDeliveringStateInstance()
        {
            if (delivering == null)
            {
                delivering = new DeliveringState();
            }
            return delivering;
        }
        public static IPossibleState GetDoneStateInstance()
        {
            if (done == null)
            {
                done = new DoneState();
            }
            return done;
        }
    }
}
