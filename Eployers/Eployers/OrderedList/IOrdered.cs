using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eployers
{
    interface IOrdered
    {
        void List(IOrderedEnumerable<Employer> empl, List<Employer> Employers);
    }
}
