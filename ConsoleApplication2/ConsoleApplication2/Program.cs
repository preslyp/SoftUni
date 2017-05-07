using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat firstCat = new Cat();
            firstCat.Name = "Alfred";
            Console.WriteLine("Cat name is {0}", firstCat.Name );
            firstCat.SayMyu();
        }
    }
}
