using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SquareRoot
{
    class Program
    {
        static void Main()
        {
            try
            { 
                int num;
                bool canConvert;
                Console.WriteLine("Enter a number: ");
                string enterNum = Console.ReadLine();
                canConvert = int.TryParse(enterNum, out num);
                Console.WriteLine(Math.Sqrt(num));
                if (canConvert !=true || num < 0)
                {
                    throw new ArgumentException();
                }
            }
            catch(ArgumentException)
            {
                Console.WriteLine("Invalid number!");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
              
        }

    }
}
