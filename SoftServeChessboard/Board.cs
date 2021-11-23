namespace ConsoleApp1
{

    //TODO Найти класс buffering и ограничить размеры вывода в консоли
    class Board
    {
        private int Width { get; set; }

        private int Height { get; set; }

        private string[,] mas;

        public Board(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;
            mas = new string[Width, Height];
            //Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
            //Console.SetBufferSize
        }

        public string[,] CreateBoard()
        {
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    if (j % 2 == 0)
                    {
                        mas[i, j] = " ";
                    }
                    else
                    {
                        mas[i, j] = "*";
                    }

                }
            }
            return mas;
        }

    }
}
