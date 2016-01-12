using Exam_Blobs.Interfaces;
using Exam_Blobs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Blobs.Core
{
    public class BlobCreator : ICreatable
    {
        public IBlob Create(string name, int health, int damage, string behavior, string attack)
        {
            Blob blob = new Blob(name, health, damage, behavior, attack);

            return blob;
        }
    }
}
