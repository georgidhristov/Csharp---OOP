using Empires.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.IO
{
    public class ConsoleWrite : IOutput
    {
        public void Write(string message)
        {
            Console.WriteLine(message); 
        }
    }
}
