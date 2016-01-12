using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1Square_Root
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    double calc = 0;
                    calc = Math.Sqrt((double)number);
                    Console.WriteLine(calc);          
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                 Console.WriteLine("Good bye");
            }
        }
    }
}
