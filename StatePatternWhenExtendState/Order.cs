using StatePattern.PossibleState;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class Order 
    {
        public int Id { get; set; }
        public double Total { get; set; }
        public string Description { get; set; }
        public DateTime CreateTime { get; set; }

        private IPossibleState currentState;

        public IPossibleState CurrentState
        {
            get
            {
                return currentState;
            }
            set
            {
                this.currentState = value;
            }
        }

        public Order()
        {
            this.currentState = new WaitingState();
        }

        public void UpdateToWaiting()
        {
            this.currentState.UpdateToWaiting(this);
        }

        public void UpdateToProcessing()
        {
            this.currentState.UpdateToProcessing(this);
        }

        public void UpdateToDelivering()
        {
            this.currentState.UpdateToDelivering(this);
        }

        public void UpdateToDone()
        {
            this.currentState.UpdateToDone(this);
        }
    }
}
