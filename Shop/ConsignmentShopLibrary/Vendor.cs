using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Vendor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Commision { get; set; }

        public Vendor()
        {
            Commision = .5;
        }
    }
}
