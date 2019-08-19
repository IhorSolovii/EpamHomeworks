using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2Task1      
{
    public abstract class Figure
    {
        public abstract void Draw();
    }
    public class Rectangle : Figure
    {
        public override void Draw()
        {
            System.Console.WriteLine("Implemented in Rectangle class");
        }
    }
    public class Square : Figure
    {
        public override void Draw()
        {
            System.Console.WriteLine("Implemented in Square class");
        }
    }
}
