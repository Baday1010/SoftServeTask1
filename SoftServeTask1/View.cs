using ConsoleApp1;
using System;

namespace SoftServeTask1
{
    class View
    {

        public double sideA { get; private set; }

        public double sideB { get; private set; }

        public double sideC { get; private set; }

        public string Name { get; private set; }

        public double S { get; private set; }

        public double p { get; private set; }


        public View()
        {
            sideA = 0;
            sideB = 0;
            sideC = 0;
            Name = "";
            S = 0;
            p = 0;
            GetValues();
        }

        private void GetValues()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Введите название треугольника: ");
                this.Name = Console.ReadLine();
                Console.ResetColor();
                Console.WriteLine("Введите первую сторону: ");
                //bool IsNumA = double.TryParse(Console.ReadLine(), out sideA);
                this.sideA = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите вторую сторону: ");
                //bool IsNumB = double.TryParse(Console.ReadLine(), out sideB);
                this.sideB = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите третью сторону: ");
                //bool IsNumC = double.TryParse(Console.ReadLine(), out sideC);
                this.sideC = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                throw new FormatException(ex.Message);
            }
        }
        
        public void PrintInfoTriangle(Triangle triangle)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[Triange {triangle.Name}]: {triangle.S} cm");
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
