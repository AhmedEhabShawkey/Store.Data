﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Model
{
    public class BaseEntity<T>
    {
        public T Id { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
