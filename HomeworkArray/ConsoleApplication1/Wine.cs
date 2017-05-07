using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Wine
    {
        public string Name;
        public decimal Price;
        public string Description;

        private decimal descount;

        public Wine(string wineName, decimal price)
        {
            this.Name = wineName;
            this.Price = price;
            this.descount = 0.0m;
        }
    }
}
