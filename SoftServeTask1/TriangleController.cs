using ConsoleApp1;
using System;

namespace SoftServeTask1
{
    class TriangleController
    {
        public Triangle triangle;

        private View view;

        public TriangleController()
        {
            view = new View();
            triangle = new Triangle(view.Name, view.sideA, view.sideB, view.sideC);
            IsTriangle(view);
           
           
        }

        private void IsTriangle(View view)
        {
            if (view.sideA + view.sideB < view.sideC || view.sideA + view.sideC < view.sideB || view.sideB + view.sideC < view.sideA ||
                view.sideA == 0 || view.sideB == 0 || view.sideC == 0)
            {
                Console.WriteLine("Это не треугольник\n");
                view = new View();
                triangle = new Triangle(view.Name, view.sideA, view.sideB, view.sideC);
            }
        }
    }
}
