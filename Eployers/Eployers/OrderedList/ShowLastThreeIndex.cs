using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eployers
{
    class ShowLastThreeIndex:IOrdered
    {
        public void List(IOrderedEnumerable<Employer> empl, List<Employer> Employers)
        {
            Console.WriteLine("Вывести последние три индекса в списке:");
            for (var i = (empl.Count()-3>=0)? empl.Count() - 3:0; i < empl.Count(); i++)
            {
                Console.WriteLine("Имя:{0}", Employers.IndexOf(empl.ElementAt(i)));
            }
        }
    }
}
