using Exam_Blobs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Blobs.Core
{
    public class ActivataBehaviorEffect : IActivatable
    {
        Behaviors behaviors = new Behaviors();

        public IBlob Activata(IBlob blob)
        {
            if (blob.Behavior == "Aggressive")
            {
                blob = behaviors.AggressiveBehavior(blob);
            }
            else if (blob.Behavior == "Inflated")
            {
                blob = behaviors.InflatedBehavior(blob);
            }     

            return blob;
        }
    }
}
