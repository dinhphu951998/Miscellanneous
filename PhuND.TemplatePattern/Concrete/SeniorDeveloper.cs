using PhuND.TemplatePattern.Abstract;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuND.TemplatePattern.Concrete
{
    class SeniorDeveloper : Candidate
    {
        public override void ApplyCV()
        {
            Console.WriteLine($"Apply CV for Senior Developer position");
        }

        public override void BehaviorInterview()
        {
            Console.WriteLine("Participate in behavior interview");
        }

        public override void Project()
        {
            Console.WriteLine("Be technical leader of the project");
        }

        public override void TechnicalInterview()
        {
            Console.WriteLine("Join a hard technical interview");
        }
    }
}
