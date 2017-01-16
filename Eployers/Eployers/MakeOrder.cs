using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eployers
{
    class MakeOrder
    {
        public IOrderedEnumerable<Employer> order(List<Employer> Employers)
        {
            var empl = from i in Employers
                       orderby i.MonthAverage() descending, i.name
                       select i;
            return empl;
        }
    }
}
