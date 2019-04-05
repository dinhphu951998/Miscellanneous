using PhuND.TemplatePattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuND.TemplatePattern.Abstract
{
    public abstract class Candidate
    {
        public string Name { get; set; }
        public void ApplyForJob()
        {
            ApplyCV();
            BehaviorInterview();
            TechnicalInterview();
            if (!IsGoodCandidate())
                InNext();
            Project();
        }

        public abstract void ApplyCV();
        public abstract void BehaviorInterview();
        public abstract void TechnicalInterview();
        public virtual void InNext()
        {
            Console.WriteLine("Participate in Next department");
        }
        public abstract void Project();

        public virtual bool IsGoodCandidate()
        {
            if (  this is SeniorDeveloper)
            {
                return true;
            }
            return false;
        }

    }
}
