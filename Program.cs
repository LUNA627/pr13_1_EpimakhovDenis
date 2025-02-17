using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr13_1_EpimakhovDenis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                ArrayList list = new ArrayList();
                list.Add(4.5);
                list.Add(18);
                list.AddRange(new string[] { "Студент", "Петров" });

                
                foreach (object e in list)
                {
                    Console.WriteLine(e);
                }

                ArrayList newlist = new ArrayList();
                Console.WriteLine();
                Console.Write("Введите индекс n1, чтобы вставить новую коллекцию: ");
                int n1 = int.Parse(Console.ReadLine());

                if (n1 > list.Count)
                {
                    Console.WriteLine("\nИндекс выходит за переделы списка");
                    return;
                }

                list.InsertRange(n1, newlist);
                Console.Write("Введите количество элементов - i для удаления: ");
                int i = int.Parse(Console.ReadLine());

                int n = n1 / 2;

                if ((n + i) <= list.Count)
                {
                    list.RemoveRange(n, i);
                }
                else
                {
                    Console.WriteLine("\nДиапазон удаления выходит за пределы списка");
                    return;
                }

                Console.WriteLine("\nНовый список: ");

                foreach (object e in list)
                {
                    Console.WriteLine(e);
                }


            }
            catch
            {
                Console.WriteLine("\nНеверный формат данных");
            }

            Console.ReadLine();
            


        }
    }
}
