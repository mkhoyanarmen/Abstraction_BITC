﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_BITC
{
    abstract class Animal
    {
        public string Name { get; set; }
        public abstract void Eat();
    }
}
