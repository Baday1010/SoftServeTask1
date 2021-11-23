using ConsoleApp1;

namespace SoftServeChessboard
{
    class BoardController
    {
        private Board board;

        private View view;

        public BoardController()
        {
            view = new View();
            board = new Board(view.Width, view.Height);
            view.mas = board.CreateBoard();
            view.DisplayBoard();
        }
    }
}
