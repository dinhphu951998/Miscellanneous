using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternWithJavaStyle
{
    class Order : Context
    {
        public int Id { get; set; }
        public double Total { get; set; }
        public string Description { get; set; }
        public DateTime CreateTime { get; set; }

        private State currentState;

        public State CurrentState
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

        public override void SetState(State state)
        {
            state.Handle(this);
        }
    }
}
