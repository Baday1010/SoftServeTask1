using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Triangle : IComparer<Triangle>, IComparable<Triangle>
    {
        private double sideA;

        private double sideB;

        private double sideC;

        private string Name;

        private double S;

        private double p;

        public void ShowInfo()
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

        public Triangle(string Name, double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            this.Name = Name;
            this.p = (sideA + sideB + sideC) / 2;
            S = Math.Sqrt((p * (p - sideC)) * (p * (p - sideB)) * (p * (p - sideB)));
        }
    }
}
