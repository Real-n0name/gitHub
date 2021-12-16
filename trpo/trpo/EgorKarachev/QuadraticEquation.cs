using lab4.EgorKarachev;
using System;
using System.Collections.Generic;

namespace EgorKarachev
{
    class QuadraticEquation : LinearEquation, EquationInterface
    {
        protected float discriminant(float a, float b, float c)
        {
            return (b * b) - (4 * a * c);
        }

        public List<float> Solve(float a, float b, float c)
        {
            if (a == 0)
            {
                return linearEquation(b, c);
            }

            float d = discriminant(a, b, c);
            if (d < 0)
            {
                throw new EgorException("Ошибка: уравнение не имеет решений.");
            }

            if (d == 0)
            {
                return new List<float> { -b / (2 * a) };
            }

            EgorLog.I().log("У вас получилось квадратное уравнение");

            d = (float)Math.Sqrt(d);

            return new List<float> { (-b - d) / (2 * a), (-b + d) / (2 * a) };
        }
    }
}
