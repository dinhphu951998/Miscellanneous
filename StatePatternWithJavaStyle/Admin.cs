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
            PossibleState processing = new ProcessingState();
            order.SetState(processing);

            //update to delivering
            PossibleState delivering = new DeliveringState();
            order.SetState(delivering);

            //the order has problem, we need to take a look back this order
            PossibleState processing2 = new ProcessingState();
            order.SetState(processing2);

            //everything now is alright. Delivery the order
            PossibleState delivering2 = new DeliveringState();
            order.SetState(delivering2);

            //Mark order done
            PossibleState done = new DoneState();
            order.SetState(done);

            Console.Read();
        }
    }
}
