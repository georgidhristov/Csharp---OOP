using Exam_Blobs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Blobs.IO
{
    public class ConsoleRead : IInput
    {
        public string Read()
        {
            string input = Console.ReadLine();

            return input;
        }
    }
}
