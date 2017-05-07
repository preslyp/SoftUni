using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandaFlag
{
    class Program
    {
        static void Main()
        {
            char currChar = 'A';
            int n = int.Parse(Console.ReadLine());
           
            Console.WriteLine(currChar++ + new string('#', n - 2) + currChar++);
                      
            for (int i = 0; i < n /2 - 1; i++)
            {
                
                Console.WriteLine(new string('~', i + 1) 
                    + (currChar == ('Z' + 1) ? 'A' : currChar++)
                                + new string('#', n - 4 - 2 * i)
                                + (currChar == ('Z' + 1) ? 'A' : currChar++) 
                                + new string('~', i + 1));
                
            }

            Console.WriteLine(new string('-', n / 2) + (currChar == ('Z' + 1) ? 'A' : currChar++) + new string('-', n / 2));

            for (int i = 0; i < n / 2 - 1; i++)
            {
                                    
                Console.WriteLine(new string('~', n / 2 - 1 - i)
                                + (currChar == ('Z' + 1) ? 'A' : currChar++)
                                + new string('#', 2*i + 1)
                                + (currChar == ('Z' + 1) ? 'A' : currChar++)
                                + new string('~', n / 2 - 1 - i));
            }

            Console.WriteLine((currChar == ('Z' + 1) ? 'A' : currChar++) + new string('#', n - 2) + (currChar == ('Z' + 1) ? 'A' : currChar++));
        }
    }
}
