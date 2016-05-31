using System;
namespace _2.LaptopShop
{
    class Battery
    {
        public string batt;
        public int batteryLife;

        public Battery(string batt = null, int batteryLife = 0)
        {
            this.batt = batt;
            this.batteryLife = batteryLife;
        }

        public string Batt
        {
            get { return this.batt; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    this.batt = null;
                this.batt = value;
            }
        }

        public int BatteryLife
        {
            get { return this.batteryLife; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("the value must be larger than 0 !");
                this.batteryLife = value;
            }
        }

        public override string ToString()
        {
            return "Battery: " + this.batt + ", Battery life: " + this.batteryLife + " hours";
        }
    }
}
