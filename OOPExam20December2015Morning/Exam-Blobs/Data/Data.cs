using Exam_Blobs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Blobs.Data
{
    public class Data : IData
    {
        List<IBlob> blobs = new List<IBlob>();

        public List<IBlob> Blobs
        {
            get { return blobs; }
            set { blobs = value; }
        }

        public void AddBlob(IBlob blob) 
        {
            blobs.Add(blob);
        }
    }
}
