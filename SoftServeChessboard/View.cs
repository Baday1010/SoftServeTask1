using ConsoleApp1;
using System;

namespace SoftServeChessboard
{
    class View
    {
        public int Width { get; private set; }

        public Board board;

        public int Height { get; private set; }

        public string[,] mas { get; set; }
        
        public View()
        {
            Width = 0;
            Height = 0;
#pragma warning disable CS0219 
            string[,] mas = null;
            GetValues();
        } 

        private void GetValues()
        {
            Console.WriteLine("Enter Width: ");
            this.Width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Height: ");
            this.Height = Convert.ToInt32(Console.ReadLine());

            this.mas = new string[Width, Height];
        }

        public void DisplayBoard()
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
    }
}
