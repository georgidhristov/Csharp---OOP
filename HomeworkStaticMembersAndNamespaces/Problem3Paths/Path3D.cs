using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3Paths
{
    public class Path3D
    {
        public static List<Point3D> sequence = new List<Point3D>();
        public Path3D() { }

        public static void AddToList(Point3D point)
        {
            sequence.Add(point);
        }

        public override string ToString()
        {
            int count = 0;
            string str = "";
            foreach (Point3D item in sequence)
            {
                count++;
                str = str + string.Format("{1} {2} {3}\n", count, item.X, item.Y, item.Z);
            }

            return str.ToString().Trim();
        }
    }
}
