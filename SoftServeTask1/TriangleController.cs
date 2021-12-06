using ConsoleApp1;
using System;
using System.Collections.Generic;

namespace SoftServeTask1
{
    public class TriangleController : IValidator
    {
        private View view;

        private Triangle triangle;

        public List<Triangle> listOfTriangles { get; private set; }

        public TriangleController()
        {
            listOfTriangles = new List<Triangle>();
            view = new View();
        }

        public void Run()
        {
            ConsoleKeyInfo input;
            do
            {
                SetValues();
                if (triangle != null)
                {
                    listOfTriangles.Add(triangle);
                    triangle = null;
                    view.ShowMessage(true);
                }
                else
                {
                    view.ShowMessage(false);
                }

                Console.WriteLine("Press Y to add triangle and N to stop adding");
                input = Console.ReadKey(true);
            } while (input.Key != ConsoleKey.N);
            listOfTriangles.Sort();
            DisplaySortedListOfTriangles();
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

                if (IsTriangle(sideA, sideB, sideC))
                {
                    triangle = new Triangle(name, sideA, sideB, sideC);
                }
            }
            catch (FormatException ex)
            {
                throw new FormatException($"{ex} In a call to a method that converts a string to some other data type, the string doesn't conform to the required pattern. ");
            }
            catch (OverflowException ex)
            {
                throw new Exception($"{ex} An arithmetic operation produces a result that is outside the range of the data type returned by the operation.");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DisplaySortedListOfTriangles()
        {     
            listOfTriangles.ForEach(view.PrintInfoTriangle);
        }

        public bool IsTriangle(double sideA, double sideB, double sideC)
        {
            bool res = true;
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA || sideA == 0 || sideB == 0 || sideC == 0)
            {
                res = false;
            }
            return res;
        }
    }
}
