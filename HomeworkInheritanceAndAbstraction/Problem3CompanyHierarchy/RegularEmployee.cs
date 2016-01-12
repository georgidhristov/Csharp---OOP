using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3CompanyHierarchy
{
    public class RegularEmployee : Person
    {
        public RegularEmployee(string id, string firstName, string lastName)
            : base(id, firstName, lastName)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
