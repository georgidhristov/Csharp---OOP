using Empires.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Models.Units
{
    public class Unit : IUnit
    {
        private string unitType;
        private int attackDamage;
        private int health;

        public Unit(string unitType, int attackDamage, int health)
        {
            this.unitType = UnitType;
            this.attackDamage = AttackDamage;
            this.health = Health;
        }

        public string UnitType
        {
            get { return unitType; }
        }

        public int AttackDamage
        {
            get { return attackDamage; }
        }

        public int Health
        {
            get { return health; }
        }
    }
}
