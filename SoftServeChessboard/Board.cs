namespace ConsoleApp1
{

    //TODO Найти класс buffering и ограничить размеры вывода в консоли
    class Board
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public string[,] mas;

        public Board(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;
            mas = new string[Width, Height];
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
