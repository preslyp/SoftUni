using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    class Program
    {
        static void Main(string[] args)
        {
            GoldenEditionBook b = new GoldenEditionBook("The noise", "Pancho Angarev", 22.90);
            Console.WriteLine(b);
        }
    }
}
