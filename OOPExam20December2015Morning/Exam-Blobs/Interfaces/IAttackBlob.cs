using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Blobs.Interfaces
{
    public interface IAttackBlob
    {
        List<IBlob> Attack(List<IBlob> blobs, string attacker, string defender);
    }
}
