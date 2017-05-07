using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LaptopShop
{
        
    class LaptopShop
    {
        static void Main()
        {
            Laptop hp = new Laptop(model: "HP 250 G2", price: 699.00m);

            Console.WriteLine(hp);
            Console.WriteLine();


            Laptop lenovo = new Laptop(
                model: "HP 250 G2",
                price: 2259.00m,
                manufacturer: "Lenovo",
                processor: "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",
                ram: "8 GB",
                graphicsCard: "Intel HD Graphics 4400",
                hdd: "128GB SSD",
                screen: "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display",
                batteryModel: "Li-Ion, 4-cells, 2550 mAh",
                batteryLife: 4.5
                );


            Console.WriteLine(lenovo);
        }
    }
}
