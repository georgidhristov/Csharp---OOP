using ExamBlobs.Interfaces;
using ExamBlobs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamBlobs.Core
{
    public class CreateBlobs : IBlobCreatable
    {
        public IBlob Create(string name, int health, int damage, string behaviorSpell, string attackSpell)
        {
            Blob blob = new Blob(name, health, damage, behaviorSpell, attackSpell);

            return blob;
        }
    }
}
