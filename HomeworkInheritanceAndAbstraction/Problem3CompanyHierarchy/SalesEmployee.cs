using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3CompanyHierarchy
{
    public class SalesEmployee : Person
    {
        private List<Sales> listOfSales = new List<Sales>();

        public SalesEmployee(string id, string firstName, string lastName, List<Sales> listOfSales) 
            : base(id, firstName, lastName) 
        {
            this.ListOfSales = listOfSales;
        }

        public List<Sales> ListOfSales
        {
            get { return listOfSales; }
            set { listOfSales = value; }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
