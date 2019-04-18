using System;

namespace Temp
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = "(true and false) or true or false and true";
            //bool result = Convert.ToBoolean(expression, null);
            var result = Boolean.Parse(expression);
            Console.WriteLine(result);

            Console.Read();
        }
    }
}
