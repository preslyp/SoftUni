using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterMusikProducer
{
    class Program
    {
        static void Main()
        {
            //input
            int albumEuro = int.Parse(Console.ReadLine()); ;
            decimal priceEuro = decimal.Parse(Console.ReadLine()); ;
            int albumNA = int.Parse(Console.ReadLine()); ;
            decimal priceNA = decimal.Parse(Console.ReadLine()); ;
            int albumSA = int.Parse(Console.ReadLine()); ;
            decimal priceSA = decimal.Parse(Console.ReadLine()); ;
            int concerts = int.Parse(Console.ReadLine()); ;
            decimal concertProfit = decimal.Parse(Console.ReadLine()); ;
            decimal comparison = 100000M;
            
                  

            //logic
            decimal totalEurope = albumEuro * priceEuro * (decimal)1.94;
            decimal totalNA = albumNA * priceNA * (decimal)1.72;
            decimal totalSA = albumSA * priceSA / (decimal)332.74;
            decimal total = totalEurope + totalNA + totalSA;
            decimal totalAfterManager = total - total * (decimal)0.35;
            decimal totalAfterTax = totalAfterManager - totalAfterManager * (decimal)0.20;
            decimal totalConcert = concerts * concertProfit * (decimal)1.94;


            if (totalConcert > comparison)
            {
                totalConcert = totalConcert - totalConcert * (decimal)0.15;
            }
         

            //output

            if (totalConcert > totalAfterTax)
            {
                Console.WriteLine("On the road again! We'll see the world and earn {0:F2}lv.", totalConcert);
            }
            else
            {
                Console.WriteLine("Let's record some songs! They'll bring us {0:F2}lv.", totalAfterTax);
            }
           
        }
    }
}
