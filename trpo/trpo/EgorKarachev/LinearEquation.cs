using lab4.EgorKarachev;
using System;
using System.Collections.Generic;

namespace EgorKarachev
{
    class LinearEquation
    {
        public List<float> linearEquation(float a, float b)
        {
            if (a == 0)
            {
                throw new EgorException("Ошибка: уравнение не существует.");
            }

            return new List<float> { -b / a };
        }
    }
}
