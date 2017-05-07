using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pococlass
{
    class Program
    {
        static void Main(string[] args)
        {
            var produce = new List<object>();

            var f1 = new Fruit("Apple", 8.5, 3);
            produce.Add(f1);
            var f2 = new Fruit();
            f2.Name = "Banana";
            f2.Weight = 4.5;
            f2.Quantity = 7;
            produce.Add(f2);

            produce.Add(new Vegetable());
            ((Vegetable) produce[2]).Name = "Curcuma";
            ((Vegetable)produce[2]).Weight = 5.5;
            ((Vegetable)produce[2]).Quantity = 9;


            Console.WriteLine("The are " + produce.Count + " items");

            foreach (var item in produce)
            {
                Console.WriteLine( item);
            }

        }
    }

    class Fruit
    {
        private string name;  
        private double weight;

        public string Name
        {
            get { return name.ToUpper(); }
            set { name = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public int Quantity { get; set; }

        public Fruit()
        { 
        }

        public Fruit(string name, double weight, int quantity)
        {
            Name = name;
            Weight = weight;
            Quantity = quantity;
        }
        public override string ToString()
        {
            return Name + " (" + Weight + "oz) :" + Quantity;
        }
    }

    class Vegetable
    {
        private string name;
        private double weight;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public int Quantity { get; set; }

        public override string ToString()
        {
            return Name + " (" + Weight + "oz) :" + Quantity;
        }

    }
}
