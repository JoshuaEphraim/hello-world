using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eployers
{
    class ShowNameofFirstFiveEmploers:IOrdered
    {
        public void List(IOrderedEnumerable<Employer> empl, List<Employer> Employers)
        {
            Console.WriteLine("Вывести первые пять имен работников в списке:");
            for (var i = 0; i < 5&&i<empl.Count(); i++)
            {
                Console.WriteLine("Имя:{0}", empl.ElementAt(i).name);
            }
        }
    }
}
