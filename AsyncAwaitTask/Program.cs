using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Application thread: {Thread.CurrentThread.ManagedThreadId}");
            DoTask();
            var x = 1 + 1;
            Console.WriteLine(x);
            Console.Read();
        }


        private static async void DoTask()
        {
            var task = Task.Run(() => {
                Task.Delay(10 * 60 * 1000);
            });

            Console.WriteLine($"Task thread before: {Thread.CurrentThread.ManagedThreadId}");

            await task;

            Console.WriteLine($"Task thread after: {Thread.CurrentThread.ManagedThreadId}");
        }


    }
}
