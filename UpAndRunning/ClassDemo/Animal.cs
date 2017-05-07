namespace ClassDemo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;

    public class Animal
    {
        private string type;
        private string color;
        private string weight;
        private string height;
        private int age;
        private int numOfLegs;

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public virtual void Move()
        {
            Console.WriteLine("Moved");
        }

        public virtual void MakeNoise()
        {
            Console.WriteLine("Made noise");
        }
    }
}
