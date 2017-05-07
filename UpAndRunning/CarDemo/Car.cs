using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDemo
{
    public class Car
    {
        private string storeMake;
        private string model;
        private ConsoleColor color;


        public string StoreMake
        {
            get { return storeMake; }
            set { storeMake = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public ConsoleColor Color
        {
            get { return color; }
            set { color = value; }
        }

        public void Drive()
        {
            Console.WriteLine("Driving");
        }

        public void Stop()
        {
            Console.WriteLine("Stoping");
        }

        public override string ToString()
        {
            return string.Format("Model: {0},\nStore Make{1}\nColor: {2}", Model, StoreMake, Color);
        }
    }
}
