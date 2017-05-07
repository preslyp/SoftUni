﻿namespace ConsoleApplication2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Cat
    {
        private string name;
        private string color;

        public Cat()
        {
            this.name = "Unnamed";
            this.color = "gray";
        }

        public Cat(string name, string color)
        {
            this.Name = name;
            this.Color = color;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Color { get; set; }

        public void SayMyu()
        {
            Console.WriteLine("Cat {0} said: Miauuuuuu", this.name);
        }
    }
}
