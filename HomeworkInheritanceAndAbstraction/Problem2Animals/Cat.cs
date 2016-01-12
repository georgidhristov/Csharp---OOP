using System;
namespace Problem2Animals
{
    public class Cat : Animal
    {
        public Cat(string name, int age, string gender) 
            : base(name, age, gender) 
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine(string.Format("meow meow... {0}, {1}, {2}", this.Name, this.Age, this.Gender));
        }
    }
}
