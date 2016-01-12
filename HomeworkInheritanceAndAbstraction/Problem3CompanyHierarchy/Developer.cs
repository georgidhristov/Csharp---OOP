using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3CompanyHierarchy
{
    public class Developer : Person
    {
        private List<Projects> listOfProjects = new List<Projects>();

        public Developer(string id, string firstName, string lastName, List<Projects> listOfProjects) 
            : base(id, firstName, lastName)
        {
            this.ListOfProjects = listOfProjects;
        }

        public List<Projects> ListOfProjects
        {
            get { return listOfProjects; }
            set { listOfProjects = value; }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
