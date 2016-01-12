using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3Paths
{
    public class Program
    {
        static void Main(string[] args)
        {
            Point3D point1 = new Point3D(3, 7, 6);
            Point3D point2 = new Point3D(2, 3, 2);
            Point3D point3 = new Point3D(4, 4, 3);

            Path3D.AddToList(point1);
            Path3D.AddToList(point2);
    
            Path3D list = new Path3D();

            Storage.SaveInFile("text.txt");
            Storage.LoadFromFile("text.txt");
        }
    }
}
