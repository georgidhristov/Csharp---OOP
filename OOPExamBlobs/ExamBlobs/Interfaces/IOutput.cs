﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamBlobs.Interfaces
{
    public interface IOutput
    {
        void Write(string massage);

        void WriteList(List<IBlob> massage);
    }
}