using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamBlobs.Interfaces
{
    public interface IBlob
    {
        string Name { get; set; }

        int Health { get; set; }

        int Damage { get; set; }

        string BehaviorType { get; set; }

        string AttackType { get; set; }
    }
}
