using ExamBlobs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamBlobs.IO
{
    public class ConsoleWrite : IOutput
    {
        public void Write(string massage)
        {
            Console.WriteLine(massage);
        }

        public void WriteList(List<IBlob> massage)
        {
            for (int i = 0; i < massage.Count(); i++)
            {
                Console.WriteLine(massage[i]);
            }
        }
    }
}
