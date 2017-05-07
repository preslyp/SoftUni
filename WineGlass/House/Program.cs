using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}*{1}", new string('.', (n-1)/2), new string('.', (n-1)/2));


            int outerDots = n / 2 - 1;
            int middleDots = 1;
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('.', outerDots), new string('.', middleDots), new string('.', outerDots));
                outerDots -= 1;
                middleDots += 2;
            }
            Console.WriteLine(new string('*', n));


            int wallDistance = n / 4;
            for (int i = n / 2 + 1; i < n - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('.', wallDistance), new string('.', n - 2 * wallDistance - 2), new string('.', wallDistance));
            }
            Console.WriteLine("{0}{1}{2}", new string('.', wallDistance), new string('*', n - 2 * wallDistance), new string('.', wallDistance));
        }
    }
}
