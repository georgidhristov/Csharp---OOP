using System;
namespace Problem1HumanStudentAndWorker
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName) 
        {
            this.FirstName = firstName;
            this.LastName = lastName;
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
            return string.Format("{0} {1}",
                this.FirstName, this.LastName);
        }
    }
}
