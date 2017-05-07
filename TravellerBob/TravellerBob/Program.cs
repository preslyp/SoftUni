using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravellerBob
{
    class Program
    {
        static void Main()
        {
            string year = Console.ReadLine();
            double mounthsContract = double.Parse(Console.ReadLine());
            double mountsFamily = double.Parse(Console.ReadLine());
            double contract;
            double family;
            double normal;
            double additional;
            double totalTravels = 0;
            double totalAllTravels = 0;

            if (year == "leap")
            {
                contract = 12 * mounthsContract;
                family = 4 * mountsFamily;
                normal = 12 - (mounthsContract + mountsFamily);
                normal *= 7.2;
                totalTravels = (contract + family + normal);
                additional =  totalTravels * 0.05 ;
                totalAllTravels = totalTravels + additional;

                Console.WriteLine(Math.Floor(totalAllTravels));
            }
            else if (year == "normal")
            {
                contract = 12 * mounthsContract;
                family = 4 * mountsFamily;
                normal = 12 - (mounthsContract + mountsFamily);
                normal *= 7.2;
                totalTravels = (contract + family + normal);

                Console.WriteLine(Math.Floor(totalTravels));
            }
        }
    }
}
