using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LaptopShop
{
      class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private Battery battery = new Battery();
        private decimal price;

        public Battery Battery
        {
            get { return this.battery; }
            set
            {
                this.battery = value;
            }
        }
        public string Model {
            get
            {
                return this.model;
            }
            set 
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException("Model's name can't not be empty");
                }
                this.model=value;
            } 
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException("Manufacturer's name can't not be empty");
                }
                this.manufacturer = value;
            }
        }
        public string Processor
        {
            get
            {
                return this.processor;
            }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException("Processor's name can't not be empty");
                }
                this.processor = value;
            }
        }
        public string Ram
        {
            get
            {
                return this.ram;
            }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException("RAM can't not be empty");
                }
                this.ram = value;
            }
        }
        public string GraphicsCard
        {
            get
            {
                return this.graphicsCard;
            }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException("GraphicsCard can't not be empty");
                }
                this.graphicsCard = value;
            }
        }
        public string Hdd
        {
            get
            {
                return this.hdd;
            }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException("HDD can't not be empty");
                }
                this.hdd = value;
            }
        }
        public string Screen
        {
            get
            {
                return this.screen;
            }
            set
            {
     
                this.screen = value;
            }
        }


        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price can't not be negative");
                }
                this.price = value;
            }
        }

        public Laptop (string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }
        public Laptop(string model, decimal price, double batteryLife, string manufacturer = null,
                    string processor=null, string ram = null, 
                    string graphicsCard = null, string hdd=null,
                    string screen = null, string batteryModel = null)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.battery.BatteryLife = batteryLife;
            this.battery.BatteryModel = batteryModel;
   
        }

        public override string ToString()
        {

            string resultLaptop = String.Format("Model: {0}", this.Model);

            if (this.Manufacturer != null)
            {
                resultLaptop += ("\nManufacturer: " + this.Manufacturer);
            }

            if (this.Processor != null)
            {
                resultLaptop += ("\nProcesor: " + this.Processor);
            }

            if (this.Ram != null)
            {
                resultLaptop += ("\nRAM: " + this.Ram);
            }

            if (this.GraphicsCard != null)
            {
                resultLaptop += ("\ngraphics card: " + this.GraphicsCard);
            }

            if (this.Hdd != null)
            {
                resultLaptop += ("\nHDD: " + this.Hdd);
            }

            if (this.Battery.BatteryModel != null)
            {
                resultLaptop += ("\nbattery model: " + this.Battery.BatteryModel);
            }
            
            resultLaptop += ("\nbattery life: " + this.Battery.BatteryLife + " hours");
            


            resultLaptop += ("\nPrice: " + this.Price + "lv.");

            return resultLaptop;
                        
        }
    
    }
}


