using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineGlass
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            char chLeft = '\u005C';
            char chRight = '\u002F';

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}", new string('.', i), new string(chLeft, 1), new string('*', n - 2 - 2 * i), new string(chRight, 1), new string('.', i));
            }


            if (n >= 12)
            {
                 for (int i = 0; i < n / 2 - 2; i++)
                 {
                     Console.WriteLine("{0}{1}{2}{3}", new string('.', n / 2 - 1), new string('|', 1), new string('|', 1), new string('.', n / 2 - 1));
                 }
                 Console.WriteLine("{0}", new string('-', n));
                 Console.WriteLine("{0}", new string('-', n));
            }
            else
            {
                for (int i = 0; i < n / 2 - 1; i++)
                {
                    Console.WriteLine("{0}{1}{2}{3}", new string('.', n / 2 - 1), new string('|', 1), new string('|', 1), new string('.', n / 2 - 1));
                }
                Console.WriteLine("{0}", new string('-', n));
            }
           
        }
    }
}
