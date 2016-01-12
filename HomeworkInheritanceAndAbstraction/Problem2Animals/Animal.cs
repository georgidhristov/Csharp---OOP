using System;
namespace Problem2Animals
{
    public abstract class Animal : ISoundProducible
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender) 
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get { return name; }
            set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name cannot be null!");
                }
                name = value; 
            }
        }

        public int Age
        {
            get { return age; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age cennot be negative");
                }
                age = value; 
            }
        }

        public string Gender
        {
            get { return gender; }
            set
            {
                if (value != "male" && value != "female")
                {
                    throw new ArgumentException("gender can be ( male / female )");
                }
                gender = value; 
            }
        }

        public virtual void ProduceSound() {}
    }
}
