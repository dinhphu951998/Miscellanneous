
using PhuND.TemplatePattern.Abstract;
using PhuND.TemplatePattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuND.TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Candidate junior = new JuniorDeveloper();
            Console.WriteLine("Junior developer");
            junior.ApplyForJob();
            Console.WriteLine();

            Candidate senior = new SeniorDeveloper();
            Console.WriteLine("Senior developer");
            senior.ApplyForJob();
            Console.Read();
        }
    }
}
