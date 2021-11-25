using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Triangle : IComparer<Triangle>, IComparable<Triangle>
    {
        private double sideA;

        private double sideB;

        private double sideC;

        public string Name { get; private set; }

        private double Perimetr
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
            return (sideA + sideB + sideC) / 2;
        }

        private double SetSquare()
        {
            return Math.Sqrt((Perimetr * (Perimetr - sideC)) * (Perimetr * (Perimetr - sideB)) * (Perimetr * (Perimetr - sideB)));
        }

        public Triangle(string Name, double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            this.Name = Name;
            
            //this.Perimetr = SetHalfPerimetr();
            //this.Square = SetSquare();
           
           
        }
    }
}
