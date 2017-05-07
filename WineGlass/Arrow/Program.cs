using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrow
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());



            Console.WriteLine("{0}{1}{2}", new string('.', n / 2), new string('#', n), new string('.', n / 2));
                        
            for (int i = 0; i < n - 2; i++)
            {
                 Console.WriteLine("{0}#{1}#{2}", new string('.', n / 2), new string('.', n -2), new string('.', n / 2));
            }

            Console.WriteLine("{0}{1}{2}", new string('#', n / 2 + 1), new string('.', n -2), new string('#', n  / 2 + 1));


            int innerDots = 2 * n - 5;
            for (int i = 1; i <= n - 2; i++)
            {
                Console.WriteLine("{0}#{1}#{2}", new string('.', i), new string('.', innerDots), new string('.', i));
                innerDots -= 2;
            }

            Console.WriteLine(new string('.', n - 1) + new string('#', 1) + new string('.', n - 1));

        }
    }
}
