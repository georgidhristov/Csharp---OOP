using Exam_Blobs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Blobs.IO
{
    public class ConsoleWrite : IOutput
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }

        public void WriteList(List<IBlob> blobs)
        {
            for (int i = 0; i < blobs.Count(); i++)
            {
                Console.WriteLine(blobs[i]);
            }
        }
    }
}
