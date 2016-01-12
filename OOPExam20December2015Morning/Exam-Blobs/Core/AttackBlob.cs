using Exam_Blobs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Blobs.Core
{
    public class AttackBlob : IAttackBlob
    {
        Attacks attaks = new Attacks();
        ActivataBehaviorEffect activataBehaviorEffect = new ActivataBehaviorEffect();

        public List<IBlob> Attack(List<IBlob> blobs, string attacker, string defender)
        {
            int attackerIndex = 0;
            int defenderIndex = 0;
            for (int i = 0; i < blobs.Count; i++)
            {
                if (blobs[i].Name == attacker)
                {
                    attackerIndex = i;
                }
                if (blobs[i].Name == defender)
                {
                    defenderIndex = i;
                }
            }

            if (blobs[attackerIndex].Attack == "PutridFart")
            {
                blobs[defenderIndex] = attaks.PutridFart(blobs[attackerIndex], blobs[defenderIndex]);
            }
            else if (blobs[attackerIndex].Attack == "Blobplode")
            {
                IBlob[] blobArray = new IBlob[2];
                blobArray = attaks.Blobplode(blobs[attackerIndex], blobs[defenderIndex]);
                blobs[attackerIndex] = blobArray[0];
                blobs[defenderIndex] = blobArray[1];
            }

            return blobs;
        }
    }
}
