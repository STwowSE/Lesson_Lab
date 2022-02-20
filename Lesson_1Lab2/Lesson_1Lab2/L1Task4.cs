using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1Lab
{
    internal class L1Task4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 4 числа:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine(a+b>c+d);
            Console.ReadKey();
        }

    }
}
