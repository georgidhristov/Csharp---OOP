using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3Paths
{
    public class Storage : Path3D
    {
        public static void SaveInFile(string fileName)
        {
            StreamWriter wr;

            using (wr = new StreamWriter(@"..\..\" + fileName))
            {
                foreach (Point3D item in sequence)
                {
                    wr.WriteLine(string.Format("{0} {1} {2}", item.X, item.Y, item.Z));
                }
            } 
        }

        public static void LoadFromFile(string fileName)
        {
            StreamReader read;

            using (read = new StreamReader(@"..\..\" + fileName))
            {
                string line;

                while ((line = read.ReadLine()) != null)
                {
                    System.Console.WriteLine(line);
                }
            }
        }
    }
}
