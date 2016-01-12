using Empires.GameEngine;
using Empires.Models.Buildings;
using Empires.Models.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.IO;
using Empires.Interfaces;
using Empires.Models;
using Empires.Models.Recorces;


namespace Empires
{
    class Program
    {
        static void Main(string[] args)
        {
            var building = new Building();
            var input = new ConsoleRead();
            var output = new ConsoleWrite();

            Engine gameEngine = new Engine(building, input, output);

            gameEngine.Run();
        }
    }
}
