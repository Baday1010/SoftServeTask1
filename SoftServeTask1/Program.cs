using SoftServeTask1;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static ConsoleKeyInfo input;

        static void Method()
        {
            /*do
            {
                double sideA = 0;
                double sideB = 0;
                double sideC = 0;
                Console.WriteLine("Введите название треугольника: ");
                string name = Console.ReadLine();
                Console.WriteLine("Введите первую сторону: ");
                bool IsNumA = double.TryParse(Console.ReadLine(), out sideA);
                Console.WriteLine("Введите вторую сторону: ");
                bool IsNumB = double.TryParse(Console.ReadLine(), out sideB);
                Console.WriteLine("Введите третью сторону: ");
                bool IsNumC = double.TryParse(Console.ReadLine(), out sideC);

                //TODO написать через try catch
                if (!IsNumA || !IsNumB || !IsNumC)
                {
                    Console.WriteLine("Ошибка! Введите число");
                    continue;
                }
                //TODO реализовать отдельным методом
                if (sideA + sideB < sideC || sideA + sideC < sideB || sideB + sideC < sideA)
                {
                    Console.WriteLine("Это не треугольник");
                    continue;
                }
                Triangle triangle = new Triangle(name, sideA, sideB, sideC);
                listOfTriangles.Add(triangle);

                Console.WriteLine("Press Y to add triangle and N to stop adding");
                input = Console.ReadKey(true);
            } while (input.Key != ConsoleKey.N);

            listOfTriangles.Sort();


            foreach (var item in listOfTriangles)
            {
                item.PrintInfoTriangle();
            }*/
        }

        static List<Triangle> Run()
        {
            List<Triangle> listOfTriangles = new List<Triangle>();
            do
            {
                TriangleController triangleController = new TriangleController();
                listOfTriangles.Add(triangleController.triangle);
                Console.WriteLine("Press Y to add triangle and N to stop adding");
                input = Console.ReadKey(true);
            } while (input.Key != ConsoleKey.N);
            return listOfTriangles;
        }

        static void Main(string[] args)
        {
            List<Triangle> listOfTriangles = Run();
            foreach (var item in listOfTriangles)
            {
                item.PrintInfoTriangle();
            }
            listOfTriangles.Sort();
        }
    }
}
