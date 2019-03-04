﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Bridge
{
    public class Raze : IBrand
    {
        public string GetBrandName()
        {
            return "雷蛇-Raze";
        }
    }
}
