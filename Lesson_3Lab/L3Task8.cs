using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Lesson_3Lab
{
    internal class L3Task8
    {
        static void Main(string[] args)
        {
            
            for (int x = 30; x <= 33; x++)
            {
                for (int y = 1; y <= 5; y++)
                {
                    Console.WriteLine(x-y);
                }
                
            }
            
            Console.ReadKey();
        }
    }
}
