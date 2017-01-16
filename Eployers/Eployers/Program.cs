using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Eployers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employer> Employers = new List<Employer>();
            AddEmployers add = new AddEmployers();
            MakeOrder order = new MakeOrder();
            add.Add(ref Employers);
            var empl = order.order(Employers);
            List<IOrdered> list = new List<IOrdered>();
            list.Add(new ShowOrderedList());
            list.Add(new ShowNameofFirstFiveEmploers());
            list.Add(new ShowLastThreeIndex());
            list.Add(new ListIntoFile());
            foreach (var i in list)
            {
                i.List(empl, Employers);
            }
            ReadFromFile read = new ReadFromFile();
            read.Read();
            Console.ReadLine();   
        }    
    }
}
