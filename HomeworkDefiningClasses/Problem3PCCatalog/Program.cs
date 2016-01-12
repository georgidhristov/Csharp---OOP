using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3PCCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            SeveralComponents components = new SeveralComponents("RAM-Card", "DDR3", 59.99m);
            SeveralComponents components2 = new SeveralComponents("CPU", "GIGABYTE", 169.99m);
            str = components.ToString() + components2.ToString().Trim();
            Computer computer = new Computer("Lenovo", str, 229.98m);

            Console.WriteLine(computer.ToString());
        }
    }

    public class Computer : SeveralComponents
    {
        //Define fields
        private string name;
        private string severalComponents;
        private decimal price;

        //Define constructors 
        public Computer(string name, string severalComponents, decimal price) 
        {
            this.Name = name;
            this.SeveralComponents = severalComponents;
            this.Price = price;
        }

        //Define getter / setter
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string SeveralComponents
        {
            get { return severalComponents; }
            set { severalComponents = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

         //Override method
        public override string ToString()
        {
            return this.name + "\n" + this.severalComponents + "\n" + price + " BGN.";
        }
    }

    public class SeveralComponents 
    {
        public string str = "";
        //Define fields
        private string name;
        private string details;
        private decimal price;

        //Define constructors 
        public SeveralComponents() { }

        public SeveralComponents(string name, string details, decimal price) 
        {
            this.name = name;
            this.details = details;
            this.price = price;
        }

        //Define getter / setter
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Details
        {
            get { return details; }
            set { details = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public override string ToString()
        {
            str = name;
            str = str + ", " + details;
            str = str + ", " + price + " BGN.\n";
            return str;
        }
    }
}
