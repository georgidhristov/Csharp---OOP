using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2DistanceCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Point3D point1 = new Point3D(2, 3, 2);
            Point3D point2 = Point3D.PrintStartingPoint();

            double distance = DistanceCalculator.CalculateDistance3DPoint(point1, point2);
            Console.WriteLine(distance);
        }
    }
}
