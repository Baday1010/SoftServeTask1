using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Triangle : IComparer<Triangle>, IComparable<Triangle>
    {
        public double SideA { get; }

        public double SideB { get; }

        public double SideC { get; }

        public string Name { get; set; }

        public double HalfPerimetr
        {
            get
            {
                return SetHalfPerimetr();
            }

        }

        public double Square
        {
            get
            {
                return SetSquare();
            }
        }

        public int Compare(Triangle t1, Triangle t2)
        {
            if (t1.Square > t2.Square)
                return 1;
            else if (t1.Square < t2.Square)
                return -1;
            else
                return 0;
        }

        public int CompareTo(Triangle obj)
        {
            return Square.CompareTo(obj.Square);
        }

        private double SetHalfPerimetr()
        {
            return (SideA + SideB + SideC) / 2;
        }

        private double SetSquare()
        {
            return Math.Sqrt((HalfPerimetr * (HalfPerimetr - SideC)) * (HalfPerimetr * (HalfPerimetr - SideB)) * (HalfPerimetr * (HalfPerimetr - SideB)));
        }

        public Triangle(string name, double sideA, double sideB, double sideC)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
            this.Name = name;
        }
    }
}
