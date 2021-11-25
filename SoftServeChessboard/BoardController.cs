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
            board = view.board;
        }

        public void Run()
        {
            board.mas = board.CreateBoard();
            view.DisplayBoard();
        }
    }
}
