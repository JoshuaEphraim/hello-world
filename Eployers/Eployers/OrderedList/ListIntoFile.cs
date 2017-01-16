using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Eployers
{
    class ListIntoFile:IOrdered
    {
        public void List(IOrderedEnumerable<Employer> empl, List<Employer> Employers)
        {
            Console.WriteLine("Записываю список в файл");
            FileStream stream = File.Create("employers.txt");
            StreamWriter write = new StreamWriter(stream);

            foreach (var i in empl)
            {
                string str = " ID: " + Employers.IndexOf(i) + " Имя: " + i.name + " Зарплата: " + i.MonthAverage();
                write.WriteLine(str);
            }
            write.Close();
        }
    }
}
