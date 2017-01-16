using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eployers
{
    abstract class Employer
    {
        abstract public string name { get; set; }
        abstract public double rate { get; set; }
        abstract public double MonthAverage();
    }
}
