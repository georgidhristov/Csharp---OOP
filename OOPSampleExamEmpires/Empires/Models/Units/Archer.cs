using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Models.Units
{
    public class Archer : Unit
    {
        private const string defaultUnitType = "Archer";
        private const int defaultAttackDamage = 7;
        private const int defaultHealth = 25;

        public Archer()
            : base(defaultUnitType, defaultAttackDamage, defaultHealth)
        {

        }

        public override string ToString()
        {

            return string.Format("{0}: {1}, {2}", defaultUnitType, defaultAttackDamage, defaultHealth);
        }
    }
}
