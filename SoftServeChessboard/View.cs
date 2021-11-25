using ConsoleApp1;
using System;

namespace SoftServeChessboard
{
    class View
    {
        public Board board;
        
        public View()
        {
            board = new Board(0, 0);
            SetValues();
        } 

        private void SetValues()
        {
            Console.WriteLine("Enter Width: ");
            board.Width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Height: ");
            board.Height = Convert.ToInt32(Console.ReadLine());

            board.mas = new string[board.Width, board.Height];
        }

        public void DisplayBoard()
        {
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(80, 80);
            Console.SetWindowSize(40, 20);
            for (int i = 0; i < board.Width; i++)
            {
                for (int j = 0; j < board.Height; j++)
                {
                    Console.Write(board.mas[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
