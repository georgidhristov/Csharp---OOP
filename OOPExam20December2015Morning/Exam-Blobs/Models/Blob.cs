using Exam_Blobs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Blobs.Models
{
    public class Blob : IBlob
    {
        private string name;
        private int health;
        private int damage;
        private string behavior;
        private string attack;

        public Blob(string name, int health, int damage, string behavior, string attack)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
            this.Behavior = behavior;
            this.Attack = attack;
        }

        public string Name
        {
            get { return name; }
            set 
            {
                if (value.Length < 0)
                {
                    throw new ArgumentNullException("Invalid input! Name cannot be null.");
                }
                name = value; 
            }
        }
        public int Health
        {
            get { return health; }
            set 
            {
                if (value < 0)
                {
                    value = 0;
                    //throw new ArgumentOutOfRangeException("Invalid input! Health cannot be negative.");
                }
                health = value; 
            }
        }
        public int Damage
        {
            get { return damage; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid input! Damage cannot be negative.");
                }
                damage = value; 
            }
        }
        public string Behavior
        {
            get { return behavior; }
            set 
            {
                if (value != "Inflated" && value != "Aggressive")
                {
                    throw new ArgumentException("Invalid input! Behavior types: Inflated, Aggressive");
                }
                behavior = value;
            }
        }
        public string Attack
        {
            get { return attack; }
            set 
            {
                if (value != "PutridFart" && value != "Blobplode")
                {
                    throw new ArgumentException("Invalid input! Attack types: PutridFart, Blobplode");
                }
                attack = value; 
            }
        }

        public override string ToString()
        {
            string result = null;

            if (this.health == 0)
            {
                result = string.Format("Blob {0}: KILLED", this.name);
            }
            else
            {
                result = string.Format("Blob {0}: {1} HP, {2} Damage", this.name, this.health, this.damage);
            }
            return result;
        }
    }
}
