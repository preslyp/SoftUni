using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int c = 3;

            Console.WriteLine("{0}{1}{2}", new string('\u0027', n), new string('^', 1), new string('\u0027', n));

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{2}", new string('\u0027', n - 1 - i), new string('^', c + 2 * i), new string('\u0027', n - 1 - i));
            }

            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.WriteLine("{0}{1}{2}", new string('\u0027', n - 1 - i), new string('^', c + 2 * i), new string('\u0027', n - 1 - i));
            }

            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.WriteLine("{0}|{1}|{2}", new string('\u0027', n - 1), new string(' ', 1), new string('\u0027', n - 1));
            }
            
            Console.WriteLine(new string('-', 2 * n + 1));
        }
    }
}
