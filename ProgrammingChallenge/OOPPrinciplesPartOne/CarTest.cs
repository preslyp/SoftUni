namespace OOPPrinciplesPartOne
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class CarTest
    {
        static void Main()
        {
            //Car test = new Car("Chevrolet", "Cruze", "Pavol Registration", "2015", 17000);

            //Console.WriteLine(test);

            ////Modify the test class from Task 1 part 6 to create a fleet, 
            /// add 4 cars to it, print the total value of the fleet to the console, 
            /// and print the value of the least and most valuable cars in the fleet to the console.
            
            Fleet fleet = new Fleet();
            Car car1 = new Car("1", "Model1", "Registration1", "2015", 10000);
            Car car2 = new Car("2", "Model2", "Registration2", "2011", 12000);
            Car car3 = new Car("3", "Model3", "Registration3", "2015", 13000);
            Car car4 = new Car("4", "Model4", "Registration4", "2011", 11000);

            fleet.Add(car1);
            fleet.Add(car2);
            fleet.Add(car3);
            fleet.Add(car4);

            Console.WriteLine("Total value for all 4 cars is: {0}", fleet.CalcFleetValue());

            double highest, lowest;

            fleet.CalcStats(out lowest, out highest);

            Console.WriteLine("The most expensive car has a value: {0}", highest);
            Console.WriteLine("The most cheep car has a value: {0}", lowest);

            ////Have the test class call GetCars on the fleet for a specified year, iterate over the resulting array (use a foreach loop) 
            ////printing the details of each car to the console.

            Car[] carYear = fleet.GetCars("2015");

            foreach (var cars in carYear)
            {
                Console.WriteLine(cars);
            }
        }
    }
}
