using Empires.Interfaces;
using Empires.Models.Recorces;
using Empires.Models.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Models.Buildings
{
    public class Archery : Building
    {
        public override IUnit CreateUnit()
        {
            Archer archer = new Archer();
            return archer;
        }

        public override IResources CreateResource()
        {
            Gold resource = new Gold();
            return resource;
        }
    }
}
