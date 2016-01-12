using ExamBlobs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamBlobs.Interfaces
{
    public interface IBlobCreatable
    {
        IBlob Create(string name, int health, int damage, string behaviorSpell, string attackSpell);
    }
}
