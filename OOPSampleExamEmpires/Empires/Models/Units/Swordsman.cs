using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Models.Units
{
    public class Swordsman : Unit
    {
        private const string defaultUnitType = "Swordman";
        private const int defaultAttackDamage = 13;
        private const int defaultHealth = 40;

        public Swordsman()
            : base(defaultUnitType, defaultAttackDamage, defaultHealth)
        {

        }
    }
}
