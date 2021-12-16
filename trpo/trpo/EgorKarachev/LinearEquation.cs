﻿using System;
using System.Collections.Generic;

namespace EgorKarachev
{
    class LinearEquation
    {
        public List<float> linearEquation(float a, float b)
        {
            if (a == 0)
            {
                return null;
            }

            return new List<float> { -b / a };
        }
    }
}
