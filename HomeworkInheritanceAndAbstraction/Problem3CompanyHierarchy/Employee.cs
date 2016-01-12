using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3CompanyHierarchy
{
    public class Employee : Person, IEmployee
    {
        private decimal salary;
        private string department;

        public Employee(string id, string firstName, string lastName, decimal salary, string department)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Solary cannot be negative!");
                }
                salary = value;
            }
        }
        public string Department
        {
            get { return department; }
            set
            {
                if (value != "Production" && value != "Accounting" && value != "Sales" && value != "Marketing")
                {
                    throw new ArgumentException("Invalid department!");
                }
                department = value;
            }
        }
    }
}
