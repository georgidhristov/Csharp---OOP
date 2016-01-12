using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamBlobs.Interfaces
{
    public interface IBehavior
    {
        int AggressiveBehavior(int blobDamage); 

        int InflatedBehavior(int blobHealth);
    }
}
