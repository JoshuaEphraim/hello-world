using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eployers
{
    class AddEmployers
    {
        public string name;
        public string rate;
        public string add;
        public void Add(ref List<Employer> Employers)
        {
            Console.WriteLine("Введите данные работника через пробел.\nИмя, ставку, а затем per hour для почасовой ставки или per month для помесячной ставки.\nДля завершения ввода введите stop.");
            do
            {
                add = Console.ReadLine();
                Console.Clear();
                if (add.Contains("per hour"))
                {
                    name = add.Substring(0, add.IndexOf(" "));
                    rate = add.Substring(add.IndexOf(" ") + 1);
                    rate = rate.Substring(0, rate.IndexOf(" "));
                    Employers.Add(new HourEmployer(name, Int32.Parse(rate)));
                }
                else
                {
                    if (add.Contains("per month"))
                    {
                        name = add.Substring(0, add.IndexOf(" "));
                        rate = add.Substring(add.IndexOf(" ") + 1);
                        rate = rate.Substring(0, rate.IndexOf(" "));
                        Employers.Add(new MonthEmployer(name, Int32.Parse(rate)));
                    }
                    else
                    {
                        if (add.Contains("stop"))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ошибка ввода.");
                        }
                    }
                }
            } while (true);
        }
    }
}
