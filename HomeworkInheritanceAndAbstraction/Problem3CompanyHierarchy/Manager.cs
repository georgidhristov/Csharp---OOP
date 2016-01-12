using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3CompanyHierarchy
{
    public class Manager : Person, IManager
    {
        private List<Employee> listOfEmployee = new List<Employee>();

        public Manager(string id, string firstName, string lastName, List<Employee> listOfEmployee)
            : base(id, firstName, lastName)
        {
            this.ListOfEmployee = listOfEmployee;
        }

        public List<Employee> ListOfEmployee
        {
            get { return listOfEmployee; }
            set { listOfEmployee = value; }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
