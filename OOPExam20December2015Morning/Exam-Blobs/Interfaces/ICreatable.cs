using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Blobs.Interfaces
{
    public interface ICreatable
    {
        IBlob Create(string name, int health, int damage, string behavior, string attack);
    }
}
