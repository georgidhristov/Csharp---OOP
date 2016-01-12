using System;
using System.Collections.Generic;
namespace Problem2Animals
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] animalAges = new int[5];

            Animal frog = new Frog("Froggy", 1, "male");
            frog.ProduceSound();
            animalAges[0] = frog.Age;

            Animal kitten = new Kitten("Kitty", 4);
            kitten.ProduceSound();
            animalAges[1] = kitten.Age;

            Animal dog = new Dog("Sharo", 10, "male");
            dog.ProduceSound();
            animalAges[2] = dog.Age;

            Animal tomcat = new Tomcat("Tiger", 6);
            tomcat.ProduceSound();
            animalAges[3] = tomcat.Age;

            Animal cat = new Cat("Fluffy", 3, "female");
            cat.ProduceSound();
            animalAges[4] = cat.Age;

            Animal cat2 = new Cat("Maui Mauski", 18, "male");
            cat2.ProduceSound();

            Console.WriteLine("Average: {0}",  calcAverage(animalAges));    
        }

        public static double calcAverage(int[] animalAges)
        {
            double average = 0;
            for (int i = 0; i < animalAges.Length; i++)
            {
                average = average + animalAges[i];
            }

            return average / animalAges.Length;
        }
    }
}
