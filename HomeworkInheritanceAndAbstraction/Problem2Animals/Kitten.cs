using System;
namespace Problem2Animals
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age, string gender = "female") 
            : base(name, age, gender = "female")
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine(string.Format("meow meow... {0}, {1}, {2}", this.Name, this.Age, this.Gender));
        }
    }
}
