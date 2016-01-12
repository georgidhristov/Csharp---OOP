using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2DistanceCalculator
{
    public static class DistanceCalculator
    {
        public static double CalculateDistance3DPoint(Point3D firstPoint, Point3D secondPoint) 
        {
            float x = firstPoint.X - secondPoint.X;
            float y = firstPoint.Y - secondPoint.Y;
            float z = firstPoint.Z - secondPoint.Z;

            double calcDis = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));

            return calcDis;
        } 
    }
}
