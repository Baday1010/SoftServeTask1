using ConsoleApp1;
using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace SoftServeTask1
{
    class TriangleController
    {
        private ConsoleKeyInfo input;

        private Triangle triangle;

        private View view;

        public List<Triangle> listOfTriangles = new List<Triangle>();

        public TriangleController()
        {
            do
            {
                view = new View();
                if (IsTriangle(view))
                {
                  
                    triangle = new Triangle(view.Name, view.sideA, view.sideB, view.sideC);
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
            foreach (var item in listOfTriangles)
            {
                view.PrintInfoTriangle(item);
            }
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

        [Test]
        private bool IsTriangle(View view)
        {
            //Assert.That(view, Is.All.Not.Null);
            if (view.sideA + view.sideB < view.sideC || view.sideA + view.sideC < view.sideB || view.sideB + view.sideC < view.sideA ||
                view.sideA == 0 || view.sideB == 0 || view.sideC == 0)
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
