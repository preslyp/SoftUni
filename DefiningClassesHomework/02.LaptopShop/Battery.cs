using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LaptopShop
{
    class Battery
    {
        private string batteryModel;
        private double batteryLife;

        public string BatteryModel
        {
            get
            {
                return this.batteryModel;
            }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new NullReferenceException("Battery's name can't not be empty or only one char");
                }
                this.batteryModel = value;
            }
        }

        public double BatteryLife
        {
            get
            {
                return this.batteryLife;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Battery's life can't not be negative");
                }
                this.batteryLife = value;
            }
        }

        public override string ToString()
        {
            StringBuilder resultBattery = new StringBuilder();
            if (this.BatteryModel != null)
            {
                resultBattery.AppendLine("battery: " + this.BatteryModel);
            }

            if (this.BatteryLife > 0)
            {
                resultBattery.AppendLine("battery life: " + this.BatteryLife);
            }

            return resultBattery.ToString();
        }

    }
}
