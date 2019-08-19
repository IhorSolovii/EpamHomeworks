using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2Task3 
{
    public class Figure
    {
        public int X { get; }
        public int Y { get; }

        public Figure(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public virtual void Draw()
        {
            System.Console.WriteLine("Implemented in class Figure");
        }
    }
    public class Rectangle : Figure
    {
        public Rectangle(int x, int y) : base (x, y) { }
        public override void Draw()
        {
            System.Console.WriteLine("Implemented in class Rectangle");
        }

    }
    public class Square : Figure
    {
        public Square(int x, int y) : base (x, y) { }
        public override void Draw()
        {
            System.Console.WriteLine("Implemented in class Square");
        }
    }
}
