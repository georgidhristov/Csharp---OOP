﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Blobs.Interfaces
{
    public interface IActivatable
    {
        IBlob Activata(IBlob blob);
    }
}