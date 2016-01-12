using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Blobs.Interfaces
{
    public interface IBlob
    {
        string Name { get; set; }

        int Health { get; set; }

        int Damage { get; set; }

        string Behavior { get; set; }

        string Attack { get; set; }
    }
}
