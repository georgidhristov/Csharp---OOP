using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Blobs.Interfaces
{
    public interface IBehaviors
    {
        IBlob AggressiveBehavior(IBlob blob);

        IBlob InflatedBehavior(IBlob blob); 
    }
}
