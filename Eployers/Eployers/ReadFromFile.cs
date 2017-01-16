using System;
using System.IO;

namespace Eployers
{
    class ReadFromFile
    {
        public void Read()
        {
            try
            {
                Console.WriteLine("Читаю из файла:");
                Console.WriteLine(File.ReadAllText("employers.txt"));
            }
            catch(System.IO.FileNotFoundException)
            {
                Console.WriteLine("Файл не найден или неверный формат");
            }   
        }
    }
}
