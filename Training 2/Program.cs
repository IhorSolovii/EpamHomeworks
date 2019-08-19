using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training2Task4;

namespace Training_2
{
    class Program
    {
        static void DrawAll(params IDrawable[] array)
        {
                for (int i = 0; i < array.Length; i++)
                    array[i].Draw();    
        }
        static void Main(string[] args)
        {
            int chooseTask; //for choosing task
            Console.WriteLine("Choose task \n from 1 to 4");
            chooseTask = Int32.Parse(Console.ReadLine());
            switch (chooseTask)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine(" Task #1");
                    Training2Task1.Square square = new Training2Task1.Square();
                    square.Draw();
                    Training2Task1.Rectangle rectangle = new Training2Task1.Rectangle();
                    rectangle.Draw();
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine(" Task #2");
                    Training2Task2.Rectangle rectTask2 = new Training2Task2.Rectangle(2, 5);
                    rectTask2.Draw();
                    Training2Task2.Square squareTask2 = new Training2Task2.Square(3,7);
                    squareTask2.Draw();
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine(" Task #3");
                    Training2Task3.Figure figure = new Training2Task3.Figure(2, 4);
                    figure.Draw();
                    Training2Task3.Rectangle rectTask3 = new Training2Task3.Rectangle(1, 8);
                    rectTask3.Draw();
                    Training2Task3.Square squareTask3 = new Training2Task3.Square(2, 4);
                    squareTask3.Draw();
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine(" Task #4");

                    var figure2  = new Figure(2, 3);
                    var rect = new Rectangle(3, 5);
                    var squaree = new Square(4, 6);
                    DrawAll(rect, squaree, figure2);
                    Console.ReadKey();
                    break;
            }
        }
    }
}
