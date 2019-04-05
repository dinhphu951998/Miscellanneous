using PhuND.TemplatePattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuND.TemplatePattern.Concrete
{
    class JuniorDeveloper : Candidate
    {
        public override void ApplyCV()
        {
            Console.WriteLine($"Apply CV for Junior position.");
        }

        public override void BehaviorInterview()
        {
            Console.WriteLine("Participate in Behavior Interview");
        }

        public override void Project()
        {
            Console.WriteLine("Participate in the project");
        }

        public override void TechnicalInterview()
        {
            Console.WriteLine("Participate in technical interview");
        }
    }
}
