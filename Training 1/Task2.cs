using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_1
{
    public class RectangleAutoProperties
    {
        double LengthOne = 0;
        double LengthTwo = 0;
        public RectangleAutoProperties(double topLeftCorner_x, double topLeftCorner_y, double bottomRightCorner_x, double bottomRightCorner_y)
        {
            // Length of the side One = | x1 - x2 |
            LengthOne = topLeftCorner_x - bottomRightCorner_x;
            if (LengthOne < 0)
            {
                LengthOne *= (-1);
            }
            // Length of the side Two = | y1 - y2 |
            LengthTwo = topLeftCorner_y - bottomRightCorner_y;
            if (LengthTwo < 0)
            {
                LengthTwo *= (-1);
            }
        } 
        public double Square {
            get { return LengthOne * LengthTwo; }
        }
        public double Perim {
            get { return (LengthOne + LengthTwo) * 2; }
        }
    }
}
