using ConsoleApp1;
using System;

namespace SoftServeTask1
{
    public class View
    {
        public Triangle triangle;

        public View()
        {
            
        }

        public void Run()
        {
            SetValues();
        }

        private void SetValues()
        {
            double sideA;
            double sideB;
            double sideC;
            string name;
            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Введите название треугольника: ");
                name = Console.ReadLine();
                Console.ResetColor();
                Console.WriteLine("Введите первую сторону: ");
                sideA = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите вторую сторону: ");
                sideB = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите третью сторону: ");
                sideC = Convert.ToDouble(Console.ReadLine());
                // TODO перенести сюда IsTriangle
                triangle = new Triangle(name, sideA, sideB, sideC);
            }
            catch (FormatException ex)
            {
                throw new FormatException("Введены неверные параметры" + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public void PrintInfoTriangle(Triangle triangle)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[Triange {triangle.Name}]: {triangle.Square} cm");
            Console.ResetColor();
        }

        public void ShowErrorMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Это не треугольник\n");
            Console.ResetColor();
        }

        public void ShowOkeyMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Треугольник добавлен в список\n");
            Console.ResetColor();
        }
    }
}
