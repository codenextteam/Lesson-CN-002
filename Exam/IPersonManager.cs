﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal interface IPersonManager<T>
    {
         void Add(T t);
    }
}
