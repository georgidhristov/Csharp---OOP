using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2LaptopShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Battery firstBattery = new Battery("Li-Ion, 4-cells, 2550 mAh", 4.5);
            Laptop firstLaptop = new Laptop("Lenovo Yoga 2 Pro", "Lenovo", "Intel Core i5-4210U", 8, "Intel HD Graphics 4400", "128GB SSD", "3200 x 1800, IPS sensor display", firstBattery.ToString(), 2259.00m);
            Laptop secondLaptop = new Laptop("HP 250 G2", 699.00m);

            Console.WriteLine(firstLaptop.ToString());
            Console.WriteLine();
            Console.WriteLine(secondLaptop.ToString());
        }
    }

    public class Laptop 
    {
        //Define fields
        private string model;
        private string manufacturer;
        private string processor;
        private int ram = -1;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private decimal price;
        private string bat;

        //Define constructors 
        public Laptop(string model, decimal price) 
        {
            this.model = model;
            this.price = price;
        }
        public Laptop(string model, string manufacturer, string processor, int ram, string graphicsCard, string hdd, string screen, string bat, decimal price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.bat = bat;
            this.Price = price;
        }

        //Define getter / setter
        public string Model 
        {
            get { return this.model; }
            set 
            {
                if (value != null)
                {
                    this.model = value;
                }
                else
                {
                    throw new ArgumentException("Invalid model!");
                }
            }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set 
            {
                if (value != null)
                {
                    this.manufacturer = value;
                }
                else
                {
                    throw new ArgumentException("Invalid manufacturer!");
                }
            }
        }
        public string Processor
        {
            get { return this.processor; }
            set 
            {
                if (value != null)
                {
                    this.processor = value;
                }
                else
                {
                    throw new ArgumentException("Invalid processor!");
                }
            }
        }
        public int Ram
        {
            get { return this.ram; }
            set 
            {
                if (value >= 0)
                {
                    this.ram = value;
                }
                else
                {
                    throw new ArgumentException("Invalid RAM!");
                }
            }
        }
        public string GraphicsCard
        {
            get { return this.graphicsCard; }
            set 
            {
                if (value != null)
                {
                    this.graphicsCard = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Graphics card!");
                }
            }
        }
        public string Hdd
        {
            get { return this.hdd; }
            set 
            {
                if (value != null)
                {
                    this.hdd = value;
                }
                else
                {
                    throw new ArgumentException("Invalid HDD!");
                }
            }
        }
        public string Screen
        {
            get { return this.screen; }
            set 
            {
                if (value != null)
                {
                    this.screen = value;
                }
                else
                {
                    throw new ArgumentException("Invalid screen!");
                }
            }
        }
        public decimal Price
        {
            get { return this.price; }
            set 
            {
                if (value >= 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentException("Invalid price!");
                }
            }
        }

        //Override method
        public override string ToString()
        {
            string str = model;
            if (manufacturer != null)
            {
                str = str + "\n" + this.manufacturer;
            }
            if (processor != null)
            {
                str = str + "\n" + this.processor;
            }
            if (ram != -1)
            {
                str = str + "\n" + this.ram + " GB";
            }
            if (graphicsCard != null)
            {
                str = str + "\n" + this.graphicsCard;
            }
            if (hdd != null)
            {
                str = str + "\n" + this.hdd;
            }
            if (screen != null)
            {
                str = str + "\n" + this.screen;
            } 
            if (bat != null)
            {
                str = str + "\n" + this.bat;
            }

            str = str + "\n" + this.price + " lv.";
            return str;
        }
    }

    public class Battery
    {
        //Define fields
        private string batteryModel;
        private double batteryLife;

        //Define constructors 
        public Battery(string batteryModel, double batteryLife) 
        {
            this.BatteryModel = batteryModel;
            this.BatteryLife = batteryLife;
        }

        //Define getter / setter
        public string BatteryModel
        {
            get { return this.batteryModel; }
            set { this.batteryModel = value; }
        }
        public double BatteryLife
        {
            get { return this.batteryLife; }
            set { this.batteryLife = value; }
        }

        //Override method
        public override string ToString()
        {
            string str = this.batteryModel;
            str = str + "\n" + this.batteryLife + " hours";
            return str;
        }
    }
}
