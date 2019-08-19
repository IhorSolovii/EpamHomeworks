using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_1
{
    public static class StaticRectangle
    {
        private static double CalculateLength(double x1, double x2)
        {
            // Length of the side = | x1 - x2 |
            var length = x1 - x2;
            if (length < 0)
            {
                length *= (-1);
            }

            return length;
        }
        public static double Perim(double topLeftCorner_x, double topLeftCorner_y, double bottomRightCorner_x, double bottomRightCorner_y)
        {
            var width = CalculateLength(topLeftCorner_x, bottomRightCorner_x);
            var height = CalculateLength(topLeftCorner_y, bottomRightCorner_y);

            return (width + height) * 2;
        }
        public static double Square(double topLeftCorner_x, double topLeftCorner_y, double bottomRightCorner_x, double bottomRightCorner_y)
        {
            var width = CalculateLength(topLeftCorner_x, bottomRightCorner_x);
            var height = CalculateLength(topLeftCorner_y, bottomRightCorner_y);
            return width * height;
        }
    }
    public static class StaticCircle
    {
        const double PI = 3.1415;
        public static double Circuit(double radius)
        {
            if (radius <= 0)
            {
                throw new System.ArgumentException("Parameter can`t be lower and equal null");
            }
            return 2 * PI * radius;
        }
        public static double CircleSquare(double radius)
        {
            if (radius <= 0)
            {
                throw new System.ArgumentException("Parameter can`t be lower and equal null");
            }
            return PI * radius * radius;
        }
    }
}
