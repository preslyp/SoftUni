using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogMeeting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first dog's name: ");
            string dogName = Console.ReadLine();
            Console.Write("Enter first dog's breed: ");
            string dogBreed = Console.ReadLine();

            // Use the Dog constructor to assign name and breed
            Dogs firstDog = new Dogs(dogName, dogBreed);

            // Create a new dog using the parameterless constructor
            Dogs secondDog = new Dogs();

            // Use properties to set name and breed
            Console.Write("Enter second dog's name: ");
            secondDog.Name = Console.ReadLine();
            Console.Write("Enter second dog's breed: ");
            secondDog.Breed = Console.ReadLine();

            // Create a Dog with no name and breed
            Dogs thirdDog = new Dogs();

            // Save the dogs in an array
            Dogs[] dogs = new Dogs[] { firstDog, secondDog, thirdDog };

            // Ask each of the dogs to bark
            foreach (Dogs dog in dogs)
            {
                dog.SayBau();
            }
        }
    }
}
