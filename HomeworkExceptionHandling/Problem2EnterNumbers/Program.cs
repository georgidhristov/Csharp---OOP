using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2EnterNumbers
{
    class Program
    {
        static void Main()
        {
            try
            {
                int start = int.Parse(Console.ReadLine());
                int end = int.Parse(Console.ReadLine());

                ReadNumber(start, end);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");
                Console.WriteLine("Enter number:");
                Main();
            }
        }

        public static void ReadNumber(int start,  int end)
        {
            int border = start;
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    if (input <= start || input >= end)
                    {
                        throw new ArgumentException();
                    }
                    else
                    {
                        if (input <= border)
                        {
                            throw new ArgumentException();
                        }
                        else
                        {
                            border = input;
                        }
                    }
                }
                catch (Exception)
                {
                    if (i == 9)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        Console.WriteLine("Enter number:");
                        i--;
                    }     
                }
            }
        }
    }
}
