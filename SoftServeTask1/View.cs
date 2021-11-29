using ConsoleApp1;
using System;

namespace SoftServeTask1
{
    public class View
    {
        public Triangle triangle;

        //public double sideA { get; private set; }

        //public double sideB { get; private set; }

        //public double sideC { get; private set; }

        //public string Name { get; private set; }

        //public double Square { get; private set; }

        //public double Perimetr { get; private set; }

        public View()
        {
            triangle = new Triangle("", 0, 0, 0);
            //sideA = 0;
            //sideB = 0;
            //sideC = 0;
            //Name = "";
            //Square = 0;
            //Perimetr = 0;
            SetValues();
        }

        private void SetValues()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Введите название треугольника: ");
                this.triangle.Name = Console.ReadLine();
                Console.ResetColor();
                Console.WriteLine("Введите первую сторону: ");
                this.triangle.sideA = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите вторую сторону: ");
                this.triangle.sideB = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите третью сторону: ");
                this.triangle.sideC = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                throw new FormatException(ex.Message);
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
    }
}
