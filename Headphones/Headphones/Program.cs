using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Headphones
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine()); ;
            int asterix = 3;
            int dashTwo = 3;
            int dash = 1;
            Console.WriteLine(new string('-', n / 2) + new string('*', n + 2) + new string('-', n / 2));

            for (int i = 0; i < n; i++)
            {
                 Console.WriteLine(new string('-', n / 2) + '*' + new string('-', n) + '*' + new string('-', n / 2));
            }

            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine(new string('-', n / 2 - 1 - i) + new string('*', asterix) + new string('-', n - 2 - 2* i) + new string('*', asterix) + new string('-', n / 2 - 1 - i));
                 asterix += 2;
            }

            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine(new string('-', dash + i) + new string('*', n - 2 - 2 * i) + new string('-', dashTwo + 2 * i) + new string('*', n - 2 - 2 * i) + new string('-', dash + i));
               
            }
            Console.WriteLine(new string('-', n / 2) + '*' + new string('-', n) + '*' + new string('-', n / 2));
        }
    }
}
