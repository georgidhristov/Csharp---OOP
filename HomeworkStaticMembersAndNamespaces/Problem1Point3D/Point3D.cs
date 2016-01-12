using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1Point3D
{
    class Point3D
    {
        private static readonly Point3D startingPoint = new Point3D(0, 0, 0);

        private int x, y, z;

        public Point3D(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D PrintStartingPoint()
        {
            return startingPoint;
        }

        public int X { get { return this.x; } set { this.x = value; } }
        public int Y { get { return this.y; } set { this.y = value; } }
        public int Z { get { return this.z; } set { this.z = value; } }


        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", this.X, this.Y, this.Z);
        }     
    }
}
