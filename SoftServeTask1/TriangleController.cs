using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftServeTask1
{
    public class TriangleController
    {
        private Triangle triangle;

        private View view;

        public List<Triangle> listOfTriangles { get; private set; }

        public TriangleController()
        {
            listOfTriangles = new List<Triangle>();
        }

        public void Run()
        {
            ConsoleKeyInfo input;
            do
            {
                view = new View();
                if (IsTriangle(view))
                {

                    triangle = new Triangle(view.triangle.Name, view.triangle.sideA, view.triangle.sideB, view.triangle.sideC);
                    listOfTriangles.Add(triangle);
                }

                Console.WriteLine("Press Y to add triangle and N to stop adding");
                input = Console.ReadKey(true);
            } while (input.Key != ConsoleKey.N);
            DisplaySortedListOfTriangles();
        }

        private void DisplaySortedListOfTriangles()
        {     
            listOfTriangles.Sort();
            listOfTriangles.ForEach(view.PrintInfoTriangle);
        }

        //private void IsTriangle(View view)
        //{
        //    if (view.sideA + view.sideB < view.sideC || view.sideA + view.sideC < view.sideB || view.sideB + view.sideC < view.sideA ||
        //        view.sideA == 0 || view.sideB == 0 || view.sideC == 0)
        //    {
        //        Console.WriteLine("Это не треугольник\n");
        //        view = new View();
        //        triangle = new Triangle(view.Name, view.sideA, view.sideB, view.sideC);
        //    }
        //}

        public bool IsTriangle(View view)
        {
            if (view.triangle.sideA + view.triangle.sideB <= view.triangle.sideC || view.triangle.sideA + view.triangle.sideC
                <= view.triangle.sideB || view.triangle.sideB + view.triangle.sideC <= view.triangle.sideA ||
                view.triangle.sideA == 0 || view.triangle.sideB == 0 || view.triangle.sideC == 0)
            {
                view.ShowErrorMessage();
                return false;
                
            }
            else
            {
                return true;
            }
            
        }
    }
}
