using System;

namespace StatePatternWithJavaStyle
{
    class Admin
    {
        static void Main(string[] args)
        {
            Order order = new Order()
            {
                Id = 2,
                Total = 1_000_000,
                Description = "Emergent",
                CreateTime = DateTime.UtcNow
            };

            //update to processing
            State processing = new ProcessingState();
            order.SetState(processing);

            //update to delivering
            State delivering = new DeliveringState();
            order.SetState(delivering);

            //the order has problem, we need to take a look back this order
            State processing2 = new ProcessingState();
            order.SetState(processing2);

            //everything now is alright. Delivery the order
            State delivering2 = new DeliveringState();
            order.SetState(delivering2);

            //Mark order done
            State done = new DoneState();
            order.SetState(done);

            Console.Read();
        }
    }
}
