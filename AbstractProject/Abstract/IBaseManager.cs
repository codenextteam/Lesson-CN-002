﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProject.Abstract
{
    internal interface IBaseManager<T> where T : class, IEntity
    {
        void Add(T t);
        void Update(T t);
        void Delete(T t);
    }
}
