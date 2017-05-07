using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseWithWindow
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int outDot = n - 1;
            int muddleDot = 1;

            Console.WriteLine("{0}*{1}",new string('.', outDot), new string('.', outDot));


            for (int i = 0; i < n -1; i++)
            {
                 Console.WriteLine("{0}*{1}*{2}",new string('.', outDot-1), new string('.', muddleDot), new string('.', outDot-1));
                 outDot -= 1;
                 muddleDot += 2;
            }
            Console.WriteLine(new string('*', 2 * n - 1));

            for (int i = 0; i < n / 4; i++)
            {
                Console.WriteLine("*{0}*", new string('.', 2*n -3));
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("*{0}{1}{2}*", new string('.', n / 2), new string('*', n -3), new string('.', n / 2));
            }

            for (int i = 0; i < n / 4; i++)
            {
                Console.WriteLine("*{0}*", new string('.', 2 * n - 3));
            }
            Console.WriteLine(new string('*', 2 * n - 1));
        }
    }
}
