namespace OOPPrinciplesPartOne
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Fleet
    {
        ////Implement a Fleet class which contains an array of Cars. The array should be 100 long. 
        ////Implement a default constructor which creates the array.

        private Car[] cars;
        private int counter;

        public Fleet()
        {
            this.cars = new Car[100];
            this.counter = 0;
        }
        
        ////Implement an Add method which adds a car to the fleet. 

        /// The car to add should be a parameter of the method. 
        /// Add the car into the next free slot in the car array. 
        /// Hint: you will need another field in the class which tracks where the next free 
        /// slot in the array is and increments it after a car has been added.

        public void Add(Car car)
        {
            this.cars[counter] = car;
            this.counter++;
        }

        ////Implement a method CalcFleetValue which calculates and returns the total value of the fleet 

        /// i.e. the summing up the value of each car in the fleet.

        public double CalcFleetValue()
        {
            double total = 0;

            for (int i = 0; i < this.counter; i++)
            {
                total += this.cars[i].GetCurrentValue();
            }

            return total;
        }

        ////Implement a method CalcStats which determines the value of the least valuable car in the fleet, 
        /// and the value of the most valuable car in the fleet, and returns them using output parameters.

        public void CalcStats(out double leastValue, out double highestValue)
        {
            leastValue = this.cars[0].GetCurrentValue();
            highestValue = this.cars[0].GetCurrentValue();

            for (int i = 0; i < this.counter; i++)
            {
                if (this.cars[i].GetCurrentValue() < leastValue)
                {
                    leastValue = this.cars[i].GetCurrentValue();
                }
                else if (this.cars[i].GetCurrentValue() > highestValue)
                {
                    highestValue = this.cars[i].GetCurrentValue();
                }
            }
        }

        ////Implement a method GetCars which returns an array of cars containing just cars for a specified year. 

        /// The specified year will be a parameter of the method. 
        /// The method needs firstly to count how many cars in the fleet are for the specified year. 
        /// And then construct a new array of just this size. And then copy in the cars for the specified year. 
        /// And finally return this newly constructed array.

        public Car[] GetCars(string year)
        {
            int count = 0;

            for (int i = 0; i < this.counter; i++)
            {
                if (this.cars[i].GetYear() == year)
                {
                    count++;
                }
            }

            Car[] carsYears = new Car[count];

            int index = 0;

            for (int i = 0; i < this.counter; i++)
            {
                if (this.cars[i].GetYear() == year)
                {
                    carsYears[index] = this.cars[i];
                    index++;
                }
            }

            return carsYears;
        }
    }
}
