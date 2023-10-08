using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // вар 2. Запросить у пользователя 5 слов, после чего вывести эти слова, каждое через пустую строку от предыдущего. Использовать 3 функции вывода.
            Console.Write("Введите пять слов:");
            string a1 = Convert.ToString(Console.ReadLine());
            string a2 = Convert.ToString(Console.ReadLine());
            string a3 = Convert.ToString(Console.ReadLine());
            string a4 = Convert.ToString(Console.ReadLine());
            string a5 = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"\n{a1}\n\n{a2}\n");
            Console.WriteLine($"{a3}\n\n{a4}\n");
            Console.WriteLine(a5);
            Console.ReadKey();
        }
    }
}
