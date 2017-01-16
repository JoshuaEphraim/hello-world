using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eployers
{
    class MonthEmployer:Employer
    {
        public override string name { get; set; }
        public override double rate { get; set; }
        public MonthEmployer(string name, double rate)
        {
            this.name = name;
            this.rate = rate;
        }
        public override double MonthAverage()
        {
            var average = rate;
            return average;
        }
    }
}
