﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoTest
{
    public static class MathHelper
    {
        public static long Factorielle (int a)
        {
            if (a <= 1)
            {
                return 1;
            }
            return a * Factorielle (a - 1);
        }
    }
}