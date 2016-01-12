using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3CompanyHierarchy
{
    public class Customer : Person
    {
        private decimal netPurchaseAmount;

        public Customer(string id,  string firstName, string lastName, decimal netPurchaseAmount) 
            : base(id, firstName, lastName) 
        {
            this.NetPurchaseAmount = netPurchaseAmount;
        }

        public decimal NetPurchaseAmount
        {
            get { return netPurchaseAmount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Net purchase amount cannot be negative!");
                }    
                netPurchaseAmount = value;
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
