using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Program
    {
        static void Main()
        {
            Animal newAnimal = new Animal();
            newAnimal.Age = -12;
            Dog newDog = new Dog();
            newDog.Color = "blue";
            Console.WriteLine(newDog.Color);
            Dog nDog = new Dog();
            nDog.Age = 5;
            nDog.Move();
            nDog.MakeNoise();
        }
    }
}
