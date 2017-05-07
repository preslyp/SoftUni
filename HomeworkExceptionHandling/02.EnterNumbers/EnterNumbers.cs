using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EnterNumbers
{
    class EnterNumbers
    {
        static int CircleNumber(int start, int end, int i)
        {
            int number = int.Parse(Console.ReadLine());

            if ((number < start) || (number > end) || (number < i))
            {
                throw new ArgumentOutOfRangeException();
            }
            return number;
        }
        static void Main()
        {
            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write("Enter number {0} in the range [{1}...{2}] : ", i, 1, 10);
                    int number = CircleNumber(1, 100, i);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("The number is not integer!");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The number is NOT in the range.");
            }
        }
    }
}
