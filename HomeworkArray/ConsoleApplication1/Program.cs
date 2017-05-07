using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Wine w1 = new Wine("Mark Ryan Desident", 52.00m);
            Wine w2 = new Wine("DeLLite Johk Estate", 75.00m);

            Console.WriteLine(w1);
        }

    }
}
