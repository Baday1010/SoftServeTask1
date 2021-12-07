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

        public Triangle(string name, double sideA, double sideB, double sideC)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
            this.Name = name;
        }

        /// <summary>
        ///Defines a method that a type implements to compare two objects.
        /// </summary>
        /// <param name="t1">First object</param>
        /// <param name="t2">Second object</param>
        /// <returns>Returns a value indicating whether one is less than, equal to, or greater than the other.</returns>
        public int Compare(Triangle t1, Triangle t2)
        {
            if (t1.Square > t2.Square)
                return 1;
            else if (t1.Square < t2.Square)
                return -1;
            else
                return 0;
        }

        /// <summary>
        /// Defines a generalized type-specific comparison method that a value type or class implements to order or sort its instances.
        /// </summary>
        /// <param name="obj">Object to compare</param>
        /// <returns>returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.</returns>
        public int CompareTo(Triangle obj)
        {
            return Square.CompareTo(obj.Square);
        }

        /// <summary>
        /// Находит полупериметр треугольника
        /// </summary>
        /// <returns>Return half perimetr</returns>
        private double SetHalfPerimetr()
        {
            return (SideA + SideB + SideC) / 2;
        }

        /// <summary>
        /// Находит площадь треугольника
        /// </summary>
        /// <returns>Return square</returns>
        private double SetSquare()
        {
            return Math.Sqrt(HalfPerimetr * (HalfPerimetr - SideA) * (HalfPerimetr - SideB) * (HalfPerimetr - SideC));
            //return Math.Sqrt((HalfPerimetr * (HalfPerimetr - SideC)) * (HalfPerimetr * (HalfPerimetr - SideB)) * (HalfPerimetr * (HalfPerimetr - SideB)));
        }

        
    }
}
