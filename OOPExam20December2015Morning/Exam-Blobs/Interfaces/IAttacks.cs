using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Blobs.Interfaces
{
    public interface IAttacks
    {
        IBlob PutridFart(IBlob attacker, IBlob defender);

        IBlob[] Blobplode(IBlob attacker, IBlob defender); 
    }
}
