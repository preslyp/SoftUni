using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bottle
{
    class Program
    {

        
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int leftSpace = n / 2;
                   
            Console.WriteLine("{0}{1}", new string(' ', leftSpace), new string('*', n + 1));

            for (int i = 0; i < n/2 + 1; i++) 
            {
                Console.WriteLine("{0}*{1}*", new string(' ', leftSpace), new string(' ', n-1));
            }

           
            leftSpace--;
        
            for (int i = 0; i < n / 2 - 1; i++) 
            {
                Console.WriteLine("{0}*{1}*", new string(' ', leftSpace - i), new string(' ', n + 1 +  2 * i));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("*{0}*", new string('.', 2 * n - 2));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("*{0}*", new string('@', 2 * n - 2));
            }


            Console.WriteLine(new string('*', 2 * n));
        }
    }
}
