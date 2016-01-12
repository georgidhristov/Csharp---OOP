using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamBlobs.Interfaces
{
    public interface IAttacking
    {
        List<IBlob> Attack(List<IBlob> blobs , string attacker, string attacked);

    }
}
