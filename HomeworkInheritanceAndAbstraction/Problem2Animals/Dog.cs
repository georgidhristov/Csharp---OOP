using System;
namespace Problem2Animals
{
    public class Dog : Animal
    {
        public Dog(string name, int age, string gender) 
            : base(name, age, gender) 
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine(string.Format("bau bau... {0}, {1}, {2}", this.Name, this.Age, this.Gender));
        }
    }
}
