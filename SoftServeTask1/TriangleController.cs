using ConsoleApp1;
using System;
using System.Collections.Generic;

namespace SoftServeTask1
{
    public class TriangleController : IValidator
    {

        private View view;

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
                view.Run();
                if (IsTriangle(view.triangle.SideA, view.triangle.SideB, view.triangle.SideC))
                {
                    listOfTriangles.Add(new Triangle(view.triangle.Name, view.triangle.SideA, view.triangle.SideB, view.triangle.SideC));
                }

                Console.WriteLine("Press Y to add triangle and N to stop adding");
                input = Console.ReadKey(true);
            } while (input.Key != ConsoleKey.N);
            listOfTriangles.Sort();
            DisplaySortedListOfTriangles();
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
                view.ShowErrorMessage();
                res = false;
                
            }
            else
            {
                view.ShowOkeyMessage();
            }
            return res;
            
        }
    }
}
