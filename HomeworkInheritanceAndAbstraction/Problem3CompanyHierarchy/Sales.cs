using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3CompanyHierarchy
{
    public class Sales
    {
        private string productName;
        private DateTime date;
        private decimal price;

        public Sales(string productName, DateTime date, decimal price) 
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        public string ProductName
        {
            get { return productName; }
            set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Product name cannot be null!");
                }
                productName = value; 
            }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative!");
                }
                price = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", ProductName, date, Price);
        }
    }
}
