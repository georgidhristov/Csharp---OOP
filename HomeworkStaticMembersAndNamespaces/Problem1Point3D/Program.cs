using System;
namespace Problem1Point3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D obj = new Point3D(2, 3, 2);
            Console.WriteLine(obj.ToString());
            Console.WriteLine(Point3D.PrintStartingPoint());
        }
    }
}
