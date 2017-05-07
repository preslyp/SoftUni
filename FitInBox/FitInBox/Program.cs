using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitInBox
{
    class Program
    {
        static void Main()
        {
            int firstBoxWidth = int.Parse(Console.ReadLine());
            int firstBoxHeight = int.Parse(Console.ReadLine());
            int firstBoxDepth = int.Parse(Console.ReadLine());
            int secondBoxWidth = int.Parse(Console.ReadLine());
            int secondBoxHeight = int.Parse(Console.ReadLine());
            int secondBoxDepth = int.Parse(Console.ReadLine());

            bool fBigger = Math.Max(firstBoxDepth, Math.Max (firstBoxHeight, firstBoxWidth)) 
                            > Math.Max(secondBoxDepth, Math.Max (secondBoxHeight, secondBoxWidth));

            if (fBigger)
            {
                if (firstBoxWidth > secondBoxWidth && firstBoxHeight > secondBoxHeight && firstBoxDepth > secondBoxDepth)
                {
                    Console.WriteLine(firstBoxDepth);
                }
            }
        }
    }
}
