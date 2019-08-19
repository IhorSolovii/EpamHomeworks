using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int chooseTask; //for choosing task
            double topLeftCorner_x, topLeftCorner_y, botRightCorner_x, botRightCorner_y, radius, real, imagine; //input data
            double perim, square, circuit, circlesquare; //OutPut Data
            Console.WriteLine("Choose task \n from 1 to 5");
            chooseTask = Int32.Parse(Console.ReadLine());
            switch (chooseTask)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine(" Enter coordinates for Rectangle");
                    Console.Write("topLeftCorner_x: ");
                    topLeftCorner_x = Double.Parse(Console.ReadLine());
                    Console.Write("topLeftCorner_y: ");
                    topLeftCorner_y = Double.Parse(Console.ReadLine());
                    Console.Write("botRightCorner_x: ");
                    botRightCorner_x = Double.Parse(Console.ReadLine());
                    Console.Write("botRightCorner_y: ");
                    botRightCorner_y = Double.Parse(Console.ReadLine());
                    Training_1.Rectangle recTask1 = new Training_1.Rectangle(topLeftCorner_x, topLeftCorner_y, botRightCorner_x, botRightCorner_y);
                    perim = recTask1.Perim();
                    Console.WriteLine($"Rectangle Perimeter = {perim}");
                    square = recTask1.Square();
                    Console.WriteLine($"Rectangle Square = {square}");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine(" Enter coordinates for Reactangle");
                    Console.Write("topLeftCorner_x: ");
                    topLeftCorner_x = Double.Parse(Console.ReadLine());
                    Console.Write("topLeftCorner_y: ");
                    topLeftCorner_y = Double.Parse(Console.ReadLine());
                    Console.Write("botRightCorner_x: ");
                    botRightCorner_x = Double.Parse(Console.ReadLine());
                    Console.Write("botRightCorner_y: ");
                    botRightCorner_y = Double.Parse(Console.ReadLine());
                    RectangleAutoProperties recTask2 = new RectangleAutoProperties(topLeftCorner_x, topLeftCorner_y, botRightCorner_x, botRightCorner_y);
                    Console.WriteLine($"Rectangle Perimeter = {recTask2.Perim}");
                    Console.WriteLine($"Rectangle Square = {recTask2.Square}");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine(" Enter radius");
                    Console.Write("Radius: ");
                    radius = Double.Parse(Console.ReadLine());
                    Circle circleTask3 = new Circle();
                    circuit = circleTask3.Circuit(radius);
                    Console.WriteLine($"Circuit = {circuit} ");
                    circlesquare = circleTask3.CircleSquare(radius);
                    Console.WriteLine($"Sircle Square  = {circlesquare}");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine(" Enter coordinates for static Rectangle");
                    Console.Write("topLeftCorner_x: ");
                    topLeftCorner_x = Double.Parse(Console.ReadLine());
                    Console.Write("topLeftCorner_y: ");
                    topLeftCorner_y = Double.Parse(Console.ReadLine());
                    Console.Write("botRightCorner_x: ");
                    botRightCorner_x = Double.Parse(Console.ReadLine());
                    Console.Write("botRightCorner_y: ");
                    botRightCorner_y = Double.Parse(Console.ReadLine());
                    perim = StaticRectangle.Perim(topLeftCorner_x, topLeftCorner_y, botRightCorner_x, botRightCorner_y);
                    Console.WriteLine($"Rectangle Perimeter = {perim}");
                    square = StaticRectangle.Square(topLeftCorner_x, topLeftCorner_y, botRightCorner_x, botRightCorner_y);
                    Console.WriteLine($"Rectangle Square = {square}");
                    Console.WriteLine(" Enter radius for static Circle");
                    Console.Write("Radius: ");
                    radius = Double.Parse(Console.ReadLine());
                    circuit = StaticCircle.Circuit(radius);
                    Console.WriteLine($"Circuit = {circuit}");
                    circlesquare = StaticCircle.CircleSquare(radius);
                    Console.WriteLine($"Circle Square = {circlesquare}");
                    Console.ReadKey();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine(" Enter real number 1");
                    Console.Write("real: ");
                    real = Double.Parse(Console.ReadLine());
                    Console.WriteLine(" Enter imagine number 1");
                    Console.Write("imagine: ");
                    imagine = Double.Parse(Console.ReadLine());
                    ComplexNumber c1 = new ComplexNumber(real, imagine);
                    Console.WriteLine(" Enter real number 2");
                    Console.Write("real: ");
                    real = Double.Parse(Console.ReadLine());
                    Console.WriteLine(" Enter imagine number 2");
                    Console.Write("imagine: ");
                    imagine = Double.Parse(Console.ReadLine());
                    ComplexNumber c2 = new ComplexNumber(real, imagine);
                    ComplexNumber c3, c4;
                    c3 = c1 * c2;
                    Console.WriteLine(c3.GetComplexNumber());
                    c4 = c1 / c2;
                    Console.WriteLine(c4.GetComplexNumber());
                    Console.ReadKey();
                    break;
            }
        }
    }
}
