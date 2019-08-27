using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int chooseTask;
            int page;
            Console.WriteLine("Choose task \n from 1 to 3");
            chooseTask = Int32.Parse(Console.ReadLine());
            switch (chooseTask)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine(" Task #1");
                    Task1 task1 = new Task1();
                    task1.DrawList();
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine(" Task #2");
                    Task2 task2 = new Task2();
                    task2.DrawList();
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine(" Task #3");
                    Task3 task3 = new Task3();
                    task3.Show();
                    Console.Write("Input number of page: ");
                    try
                    {
                        page = Int32.Parse(Console.ReadLine());
                        task3.DisplayPage(page);
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine("{0} The page number you entered isn`t a numeric or is out of range", e.Message);
                        break;
                    }
                    Console.ReadKey();
                    break;
            }
        }
    }
}
