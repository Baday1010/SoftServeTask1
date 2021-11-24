using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Triangle : IComparer<Triangle>, IComparable<Triangle>
    {
        private double sideA;

        private double sideB;

        private double sideC;

        public string Name { get; private set; }

        public double S { get; private set; }

        private double p;



        public void PrintInfoTriangle()
        {
            Console.WriteLine($"[Triange {Name}]: {S} cm");
        }


        public int Compare(Triangle t1, Triangle t2)
        {
            if (t1.S > t2.S)
                return 1;
            else if (t1.S < t2.S)
                return -1;
            else
                return 0;
        }

        public int CompareTo(Triangle obj)
        {
            return S.CompareTo(obj.S);
        }

        private double SetHalfPerimetr()
        {
            return (sideA + sideB + sideC) / 2;
        }

        private double SetSquare()
        {
            return Math.Sqrt((p * (p - sideC)) * (p * (p - sideB)) * (p * (p - sideB)));
        }

        public Triangle(string Name, double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            this.Name = Name;
            this.p = SetHalfPerimetr();
            this.S = SetSquare();
           
           
        }
    }
}
