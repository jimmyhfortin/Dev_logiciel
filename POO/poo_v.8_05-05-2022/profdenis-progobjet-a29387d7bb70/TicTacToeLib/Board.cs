using System.Text;

namespace TicTacToeLib;

public class Board
{
    public const char Blank = '_';
    public const char Player1 = 'X';
    public const char Player2 = 'O';
    public const int Width = 3;

    private readonly char[] _board;

    public char this[int x, int y]
    {
        get => Get(x, y);
        set => Set(x, y, value);
    }
    
    public Board()
    {
        _board = new char[Width * Width];
        Reset();
    }

    public Board(char[] board)
    {
        ValidateBoard(board);
        _board = board;
    }

    public Board(string board)
    {
        _board = board.ToCharArray();
        ValidateBoard(_board);
    }

    
    public char Get(int row, int column)
    {
        // row and column are validated in Index
        // ValidatePosition(row, column);

        return _board[Index(row, column)];
    }

    public void Set(int row, int column, char c)
    {
        // row and column are validated in Index
        // ValidatePosition(row, column);

        ValidateChar(c);

        _board[Index(row, column)] = c;
    }


    public char Winner()
    {
        // will not work if Width is not equal to 3
        //TODO: make it work with Width other than 3
        for (int i = 0; i < Width * Width; i += Width)
        {
            // rows
            if (_board[i] != Blank && _board[i] == _board[i + 1] && _board[i] == _board[i + 2])
                return _board[i];
        }

        for (int i = 0; i < Width; i++)
        {
            // columns
            if (_board[i] != Blank && _board[i] == _board[i + Width] && _board[i] == _board[i + 2 * Width])
                return _board[i];
        }

        // diagonals
        if (_board[0] != Blank && _board[0] == _board[Width + 1] &&
            _board[Width + 1] == _board[2 * Width + 2])
            return _board[0];
        if (_board[Width - 1] != Blank && _board[Width - 1] == _board[Width + 1] &&
            _board[Width + 1] == _board[2 * Width])
            return _board[Width - 1];
        return Blank;
    }

    public void Reset()
    {
        for (int i = 0; i < _board.Length; i++)
        {
            _board[i] = Blank;
        }
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < _board.Length; i++)
        {
            char c = _board[i];
            builder.Append(c);
            builder.Append(' ');
            // if (i % 3 == 2) {
            if (Column(i) == Width)
            {
                builder.Append('\n');
            }
        }

        return builder.ToString();
    }
    
    private static void ValidateChar(char c)
    {
        if (c != Blank && c != Player1 && c != Player2)
        {
            throw new ArgumentException($"The character must be {Blank} or {Player1} or {Player2}: {c}", nameof(c));
        }
    }

    private static void ValidateBoard(char[] board)
    {
        if (board.Length != Width * Width)
        {
            throw new ArgumentException($"Board length must be {Width * Width}", nameof(board));
        }

        foreach (var c in board)
        {
            ValidateChar(c);
        }
    }

    private static void ValidatePosition(int row, int column)
    {
        if (row < 1 || row > Width)
        {
            throw new ArgumentException($"row must be between 1 and {Width} inclusive", nameof(row));
        }

        if (column < 1 || column > Width)
        {
            throw new ArgumentException($"column must be between 1 and {Width} inclusive", nameof(column));
        }
    }

    private static void ValidateIndex(int index)
    {
        if (index < 0 || index >= Width * Width)
        {
            throw new ArgumentException($"index must be between 0 and {Width * Width - 1} inclusive", nameof(index));
        }
    }

    private static int Index(int row, int column)
    {
        ValidatePosition(row, column);
        return (row - 1) * Width + (column - 1);
    }

    private static int Row(int index)
    {
        ValidateIndex(index);
        return index / Width + 1;
    }

    private static int Column(int index)
    {
        ValidateIndex(index);
        return index % 3 + 1;
    }

}