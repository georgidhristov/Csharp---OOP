using ExamBlobs.Interfaces;
using ExamBlobs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamBlobs.GameData
{
    public class Data
    {
        private List<IBlob> blobs = new List<IBlob>();

        public List<IBlob> Blobs
        {
            get { return blobs; }
            set { blobs = value; }
        }

        public void AddBlob(IBlob blob)
        {
            Blobs.Add(blob);
        }
    }
}
