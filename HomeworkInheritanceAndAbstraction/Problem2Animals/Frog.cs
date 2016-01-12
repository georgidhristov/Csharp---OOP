using System;
namespace Problem2Animals
{
    public class Frog : Animal
    {
        public Frog(string name, int age, string gender) 
            : base(name, age, gender) 
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine(string.Format("croak croak... {0}, {1}, {2}", this.Name, this.Age, this.Gender));
        }
    }
}
