using System;
namespace Problem3CompanyHierarchy
{
    public class Person : IPerson
    {
        private string id;
        private string firstName;
        private string lastName;

        public Person(string id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string Id
        {
            get { return id; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Id cannot be null!");
                }
                id = value;
            }
        }
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("First name cannot be null!");
                }
                firstName = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Last name cannot be null!");
                }
                lastName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1} {2} ", this.Id, this.FirstName, this.LastName);
        }
    }
}
