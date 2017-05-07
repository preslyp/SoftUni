using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Dog : Animal
    {
        public string name;
        public string owner;

        public override void Move()
        {
            Console.WriteLine("Running");
        }
    }
}
