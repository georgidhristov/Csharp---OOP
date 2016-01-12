using Exam_Blobs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Blobs.Core
{
    public class Behaviors : IBehaviors
    {
        public IBlob AggressiveBehavior(IBlob blob)
        {
            blob.Damage = blob.Damage * 2;

            return blob;
        }

        public IBlob InflatedBehavior(IBlob blob)
        {
            blob.Health = blob.Health + 50;

            return blob;
        }
    }
}
