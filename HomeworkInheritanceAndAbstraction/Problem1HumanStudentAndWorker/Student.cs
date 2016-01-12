using System;
namespace Problem1HumanStudentAndWorker
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber) 
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return facultyNumber; }
            set 
            {
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("Invalid faculty number!");
                }
                    facultyNumber = value; 
            }
        }

        public override string ToString()
        {
            return base.ToString() + " - " + facultyNumber;
        }
    }
}
