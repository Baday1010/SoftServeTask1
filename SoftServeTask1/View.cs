using ConsoleApp1;
using System;

namespace SoftServeTask1
{
    public class View
    {
        public View()
        {
            
        }
        
        public void PrintInfoTriangle(Triangle triangle)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[Triange {triangle.Name}]: {triangle.Square} cm");
            Console.ResetColor();
        }

        public void ShowMessage(bool flag)
        {
            if (flag)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Треугольник добавлен в список\n");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Это не треугольник\n");
                Console.ResetColor();
            }
        }
    }
}
