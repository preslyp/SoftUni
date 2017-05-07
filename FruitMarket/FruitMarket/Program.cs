using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitMarket
{
    class Program
    {
        static void Main()
        {
            string dayOfWeek = Console.ReadLine();
            double quantFirstProduct = double.Parse(Console.ReadLine());
            string firstProduct = Console.ReadLine();
            double quantSecondProduct = double.Parse(Console.ReadLine());
            string secondProduct = Console.ReadLine();
            double quantThirdProduct = double.Parse(Console.ReadLine());
            string thirdProduct = Console.ReadLine();

            Dictionary<string, double> products = new Dictionary<string, double>();

            products.Add("banana", 1.8);
            products.Add("cucumber", 2.75);
            products.Add("tomato", 3.2);
            products.Add("orange", 1.6);
            products.Add("apple", 0.86);

            switch (dayOfWeek)
            {
                case "Friday":
                    {
                        products["banana"] -= 10.0 / 100.0 * products["banana"];
                        products["cucumber"] -= 10.0 / 100.0 * products["cucumber"];
                        products["tomato"] -= 10.0 / 100.0 * products["tomato"];
                        products["orange"] -= 10.0 / 100.0 * products["orange"];
                        products["apple"] -= 10.0 / 100.0 * products["apple"];
                        break;
                    }
                case "Sunday":
                    {
                        products["banana"] -= 5.0 / 100.0 * products["banana"];
                        products["cucumber"] -= 5.0 / 100.0 * products["cucumber"];
                        products["tomato"] -= 5.0 / 100.0 * products["tomato"];
                        products["orange"] -= 5.0 / 100.0 * products["orange"];
                        products["apple"] -= 5.0 / 100.0 * products["apple"];
                        break;
                    }
                case "Tuesday":
                    {
                        products["banana"] -= 20.0 / 100.0 * products["banana"];
                        products["orange"] -= 20.0 / 100.0 * products["orange"];
                        products["apple"] -= 20.0 / 100.0 * products["apple"];
                        break;
                    }
                case "Wednesday":
                    {
                        products["cucumber"] -= 10.0 / 100.0 * products["cucumber"];
                        products["tomato"] -= 10.0 / 100.0 * products["tomato"];
                        break;
                    }
                case "Thursday":
                    {
                        products["banana"] -= 30.0 / 100.0 * products["banana"];
                        break;
                    }
            }

            double sum = 0;
            sum = quantFirstProduct * products[firstProduct] + quantSecondProduct * products[secondProduct] + quantThirdProduct * products[thirdProduct];
            Console.WriteLine(sum);

        }
    }
}
