using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_1
{
    public class Rectangle
    {
        public double LengthOne { get; set; } = 0;
        public double LengthTwo { get; set; } = 0;
        public Rectangle(double topLeftCorner_x, double topLeftCorner_y, double bottomRightCorner_x, double bottomRightCorner_y)
        {
            // Length of the side One = | x1 - x2 |
            this.LengthOne = topLeftCorner_x - bottomRightCorner_x;
            if (LengthOne < 0)
            {
                LengthOne = LengthOne * (-1);
            }

            // Length of the side Two = | y1 - y2 |
            this.LengthTwo = topLeftCorner_y - bottomRightCorner_y;
            if (LengthTwo < 0)
            {
                LengthTwo = LengthTwo * (-1);
            }
        }
        public double Perim()
        {
            return (LengthOne + LengthTwo) * 2;
        }
        public double Square()
        {
            return LengthOne * LengthTwo;
        }

    }
}
