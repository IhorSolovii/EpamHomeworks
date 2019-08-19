using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_1
{
    public class Circle
    {
        private const double PI = 3.1415;
        public double Circuit (double radius)
        {
            if (radius <= 0)
            {
                throw new System.ArgumentException("Parameter can`t be lower and equal null");
            }
            return 2 * PI * radius;
        }
        public double CircleSquare (double radius)
        {
            if (radius <= 0)
            {
                throw new System.ArgumentException("Parameter can`t be lower and equal null");
            }
            return PI * radius * radius;
        }
    }
}
