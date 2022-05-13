using TicTacToeLib;

namespace TicTacToeApp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Board board = new Board();
            Console.WriteLine(board);
            board.Set(1, 1, Board.Player1);
            board.Set(2, 3, Board.Player2);
            Console.WriteLine(board);
            board = new Board(new char[]{
                Board.Player1, Board.Player2, Board.Blank,
                Board.Blank, Board.Blank, Board.Blank,
                Board.Blank, Board.Blank, Board.Blank
            });
            Console.WriteLine(board);
            board = new Board("XOXO_____");
            Console.WriteLine(board);
            board[3, 2] = 'X';
            board[2, 2] = 'O';
            Console.WriteLine(board);
        }
    }
}