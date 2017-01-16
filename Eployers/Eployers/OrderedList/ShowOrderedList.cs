using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eployers
{
    class ShowOrderedList:IOrdered
    {
        public void List(IOrderedEnumerable<Employer> empl, List<Employer> Employers)
        {
            Console.WriteLine("Вывести отсортерованный список работников:");
            foreach (var i in empl)
            {
                Console.WriteLine("ID: {0} Имя: {1} Зарплата: {2}", Employers.IndexOf(i), i.name, i.MonthAverage());
            }
        }
    }
}
