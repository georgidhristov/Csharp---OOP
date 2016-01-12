using Empires.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.IO
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
