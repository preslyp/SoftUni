namespace OOPPrinciplesPartOne
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Car
    {
        ////Implement a Car class which has fields to store the car’s make, 
        ////model, registration, year (of initial registration), and current value

        private string make;
        private string model;
        private string registration;
        private string year;
        private double currentValue;

        ////Implement a constructor for the Car class which takes parameters corresponding 
        ////to each of the fields above and constructs an object with these values.

        public Car(string make, string model, string registration, string year, double currentValue)
        {
            this.make = make;
            this.model = model;
            this.registration = registration;
            this.year = year;
            this.currentValue = currentValue;
        }

        //// Implement a method which returns the current value of the car

        public double GetCurrentValue()
        {
            return this.currentValue;
        }

        ////Implement a method which returns the year of the car

        public string GetYear()
        {
            return this.year;
        }

        ////Override ToString to return a string containing full information about the car

        public override string ToString()
        {
            return string.Format(
                                 "Car Make: {0}\n" +
                                 "Car Model: {1}\n" +
                                 "Car Registration: {2}\n" +
                                 "Car Year: {3}\n" +
                                 "Current Value: {4}",
                                 this.make,
                                 this.model,
                                 this.registration,
                                 this.year,
                                 this.currentValue);
        }
    }
}
