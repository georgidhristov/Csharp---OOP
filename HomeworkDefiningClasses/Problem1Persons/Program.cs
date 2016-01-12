using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            Person human = new Person("Pesho", 18, "pesho@gmail.com");

            Console.WriteLine(human.ToString());
        }
    }

    public class Person 
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            set 
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException("Invalid name!");
                }
                else
                {
                    this.name = value; 
                }
            }
        }
        public int Age
        {
            get { return this.age; }
            set 
            {
                if (value >= 1 && value <= 100)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentException("Invalid age! [1...100]");
                }
            }
        }
        public string Email
        {
            get { return this.email; }
            set 
            {
                if (value.Contains("@"))
                {
                    this.email = value;
                }
                else
                {
                    throw new ArgumentException("Invalid email!");
                }     
            }
        }

        public override string ToString()
        {
            return "Person: " + Name + " " + Age + " " + Email;
        }
    }
}
