using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eployers
{
    class HourEmployer:Employer
    {
        public override string name { get; set; }
        public override double rate { get; set; }
        public HourEmployer(string name, double rate)
        {
            this.name = name;
            this.rate = rate;
        }
        public override double MonthAverage()
        {
            var average = 20.8 * 8 * rate;
            return average;
        }
    }
}
