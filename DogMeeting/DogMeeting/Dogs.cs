using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogMeeting
{
    public class Dogs
    {
        public event EventHandler NameChanged;
        private string name;
        private string breed;

        public Dogs()
        {
            
        }
        public Dogs(string name, string breed)
        { 
        
            this.name = name;
        
            this.breed = breed; 
            
        }

        public string Name
            {
                get { return this.name; }
                set { this.name = value; }
            }

        public string Breed
            {
                get { return this.breed; }
                set { this.breed = value; }
            }

        public void SayBau()
            {
                Console.WriteLine("{0} said: Bauuuuuu!", 
                    this.name ?? "[unnamed dog]");
            }

    }
}
