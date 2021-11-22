using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static ConsoleKeyInfo input;
        static void Main(string[] args)
        {
            Field field = new Field(20, 20);
            field.CreateField();
            field.DisplayField();

            Console.WriteLine();
            Console.WriteLine();

            List<Triangle> listOfTriangles = new List<Triangle>();

            do
            {
                double resA = 0;
                double resB = 0;
                double resC = 0;
                Console.WriteLine("Введите название треугольника: ");
                string name = Console.ReadLine();
                Console.WriteLine("Введите первую сторону: ");
                bool IsNumA = double.TryParse(Console.ReadLine(), out resA);
                Console.WriteLine("Введите вторую сторону: ");
                bool IsNumB = double.TryParse(Console.ReadLine(), out resB);
                Console.WriteLine("Введите третью сторону: ");
                bool IsNumC = double.TryParse(Console.ReadLine(), out resC);

                if (!IsNumA || !IsNumB || !IsNumC)
                {
                    Console.WriteLine("Ошибка! Введите число");
                    continue;
                }
                if (resA + resB < resC || resA + resC < resB || resB + resC < resA)
                {
                    Console.WriteLine("Это не треугольник");
                    continue;
                }
                Triangle triangle = new Triangle(name, resA, resB, resC);
                listOfTriangles.Add(triangle);

                Console.WriteLine("Press Y to add triangle and N to stop adding");
                input = Console.ReadKey(true);
            } while (input.Key != ConsoleKey.N);

            listOfTriangles.Sort();


            foreach (var item in listOfTriangles)
            {
                item.ShowInfo();
            }

        }
    }
}
