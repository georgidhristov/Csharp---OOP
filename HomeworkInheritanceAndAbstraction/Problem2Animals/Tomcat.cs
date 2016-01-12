using System;
namespace Problem2Animals
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age, string gender = "male") 
            : base(name, age, gender = "male")
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine(string.Format("meow meow... {0}, {1}, {2}", this.Name, this.Age, this.Gender));
        }
    }
}
