using ExamBlobs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamBlobs.Models
{
    public class Blob : IBlob
    {
        private string name;
        private int health;
        private int damage;
        private string behaviorType;
        private string attackType;

        public Blob(string name, int health, int damage, string behaviorType, string attackType)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
            this.BehaviorType = behaviorType;
            this.AttackType = attackType; 
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }
        public string BehaviorType
        {
            get { return behaviorType; }
            set { behaviorType = value; }
        }
        public string AttackType
        {
            get { return attackType; }
            set { attackType = value; }
        }

        public override string ToString()
        {
            return string.Format("Blob {0}: {1} HP, {2} Damage", this.name, this.health, this.damage);
        }
    }
}
