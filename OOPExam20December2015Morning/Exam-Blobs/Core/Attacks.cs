using Exam_Blobs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Blobs.Core
{
    public class Attacks : IAttacks
    {
        ActivataBehaviorEffect activataBehaviorEffect = new ActivataBehaviorEffect();

        public IBlob PutridFart(IBlob attacker, IBlob defender)
        {
            int defenderHalfHealth = defender.Health / 2;

            defender.Health = defender.Health - attacker.Damage;

            if (defender.Health <= defenderHalfHealth)
            {
                defender = activataBehaviorEffect.Activata(defender);
            }

            return defender;
        }

        public IBlob[] Blobplode(IBlob attacker, IBlob defender)
        {
            int attackerHalfHealth = attacker.Health / 2;
            int defenderHalfHealth = defender.Health / 2;

            int remainedHealth = attacker.Health / 2;
            attacker.Health = remainedHealth;

            if (attacker.Health <= attackerHalfHealth)
            {
                attacker = activataBehaviorEffect.Activata(attacker);
            }

            defender.Health = defender.Health - (attacker.Damage * 2);

            if (defender.Health <= defenderHalfHealth)
            {
                defender = activataBehaviorEffect.Activata(defender);
            }

            IBlob[] blobArray = { attacker, defender };

            return blobArray;
        }
    }
}
