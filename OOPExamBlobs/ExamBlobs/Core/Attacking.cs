using ExamBlobs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamBlobs.Core
{
    public class Attacking : IAttacking
    {
        public List<IBlob> Attack(List<IBlob> blobs, string attacker, string attacked)
        {
            if (blobs[0].Name == attacker)
            {
                int attackerCanActivate = blobs[0].Health / 2;
                int attackedCanActivate = blobs[1].Health / 2;

                if (blobs[0].AttackType == "PutridFart")
                {
                    blobs[1].Health = blobs[1].Health - blobs[0].Damage;
                }
                else if (blobs[0].AttackType == "Blobplode")
                {
                    int healthLeft = blobs[0].Health / 2;
                    blobs[0].Health = healthLeft;

                    blobs[0].Damage = blobs[0].Damage;

                    blobs[1].Health = blobs[1].Health - (blobs[0].Damage * 2);
                }
                while (blobs[0].Health < 0)
                {
                    blobs[0].Health++;
                }
                while (blobs[1].Health < 0)
                {
                    blobs[1].Health++;
                }
                if (blobs[0].Health <= attackerCanActivate)
                {
                    if (blobs[0].BehaviorType == "Aggressive")
                    {
                        blobs[0].Damage = blobs[0].Damage * 2;
                    }
                    else if (blobs[0].BehaviorType == "Inflated")
                    {
                        blobs[0].Health = blobs[0].Health + 50;
                    }
                }
                if (blobs[1].Health <= attackedCanActivate)
                {
                    if (blobs[1].BehaviorType == "Aggressive")
                    {
                        blobs[1].Damage = blobs[1].Damage * 2;
                    }
                    else if (blobs[1].BehaviorType == "Inflated")
                    {
                        blobs[1].Health = blobs[1].Health + 50;
                    }
                }
            }
            else if (blobs[1].Name == attacker)
            {
                int attackerCanActivate = blobs[0].Health / 2;
                int attackedCanActivate = blobs[1].Health / 2;

                if (blobs[1].AttackType == "PutridFart")
                {
                    blobs[0].Health = blobs[0].Health - blobs[1].Damage;
                }
                else if (blobs[1].AttackType == "Blobplode")
                {
                    int healthLeft = blobs[1].Health / 2;
                    blobs[1].Health = healthLeft;

                    blobs[1].Damage = blobs[1].Damage;

                    blobs[0].Health = blobs[0].Health - (blobs[1].Damage * 2);
                }
                while (blobs[1].Health < 0)
                {
                    blobs[1].Health++;
                }
                while (blobs[0].Health < 0)
                {
                    blobs[0].Health++;
                }
                if (blobs[1].Health <= attackerCanActivate)
                {
                    if (blobs[1].BehaviorType == "Aggressive")
                    {
                        blobs[1].Damage = blobs[1].Damage * 2;
                    }
                    else if (blobs[1].BehaviorType == "Inflated")
                    {
                        blobs[1].Health = blobs[1].Health + 50;
                    }
                }
                if (blobs[0].Health <= attackedCanActivate)
                {
                    if (blobs[0].BehaviorType == "Aggressive")
                    {
                        blobs[0].Damage = blobs[0].Damage * 2;
                    }
                    else if (blobs[0].BehaviorType == "Inflated")
                    {
                        blobs[0].Health = blobs[0].Health + 50;
                    }
                }
            }

            return blobs;
        }
    }
}
