using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Field
    {
        private int Width { get; set; }

        private int Height { get; set; }

        string[,] mas;

        public void CreateField()
        {
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    if (j % 2 == 0)
                    {
                        //Console.Write(" ");
                        mas[i, j] = " ";
                    }
                    else
                    {
                        //Console.Write("*");
                        mas[i, j] = "*";
                    }

                }
                //Console.WriteLine();
            }
        }

        public void DisplayField()
        {
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Console.Write(mas[i, j]);
                }
                Console.WriteLine();
            }
        }
        public Field(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;
            mas = new string[Width, Height];
        }
    }
}
