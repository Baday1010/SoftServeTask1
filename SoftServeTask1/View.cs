using ConsoleApp1;
using System;

namespace SoftServeTask1
{
    public class View
    {
        public View()
        {
            
        }
        
        /// <summary>
        /// Вывод информации о треугольнике
        /// </summary>
        /// <param name="triangle">Объект треугольник</param>
        public void PrintInfoTriangle(Triangle triangle)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[Triange {triangle.Name}]: {Math.Round(triangle.Square, 2)} cm");
            Console.ResetColor();
        }

        /// <summary>
        /// Выводит информацию о том добавлен объект треугольник в лист или нет
        /// </summary>
        /// <param name="flag"></param>
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
