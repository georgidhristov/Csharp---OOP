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
    public class Barracks : Building
    {
        public override IUnit CreateUnit()
        {
            Swordsman swordsman = new Swordsman();
            return swordsman;
        }

        public override IResources CreateResource()
        {
            Steel resource = new Steel();
            return resource;
        }
    }
}
