using System;

namespace StatePattern
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
            order.UpdateToProcessing();

            //update to delivering
            order.UpdateToDelivering();

            //the order has problem, we need to take a look back this order
            order.UpdateToProcessing();

            //everything now is alright. Delivery the order
            order.UpdateToDelivering();

            //Mark order done
            order.UpdateToDone();

            Console.Read();
        }
    }
}
