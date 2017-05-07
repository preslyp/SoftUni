using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandTheftExamo
{
    class Program
    {
        static void Main()
        {
            int escapeAttempts = int.Parse(Console.ReadLine()); ;
            long totalSlapped = 0;
            long totalEscaped = 0;
            long totalBeers = 0;
            long totalTheves = 0;
            int onePack = 6;

            for (int i = 0; i < escapeAttempts; i++)
            {
                
                    int thieves = int.Parse(Console.ReadLine());
                    int beers = int.Parse(Console.ReadLine());
                    totalTheves += thieves;
                    totalBeers += beers; 
                            
                                
            }

            if (totalTheves > 5)
            {
              totalSlapped = 5 * escapeAttempts;
              totalEscaped = totalTheves - totalSlapped;
            }
            else
            {
                totalSlapped += totalTheves;

            }
            

            Console.WriteLine("{0} thieves slapped.", totalSlapped);
            Console.WriteLine("{0} thieves escaped.", totalEscaped);

            if (totalBeers >= onePack)
            {
                long allPack = totalBeers / onePack;
                long otherBeers = totalBeers % onePack;
                Console.WriteLine("{0} packs, {1} bottles.", allPack, otherBeers);
            }
            else
            {
                Console.WriteLine("{0} packs, {1} bottles.", 0, totalBeers);
            }
         
        }
    }
}
