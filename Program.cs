using Mission_4;

class Program
{
    static void Main(string[] args)
    {
        // Example board: 1D array with some moves ('X', 'O') and empty cells ('\0')
        char[] board = new char[9]
        {
            'X', 'O', 'X',
            '\0', 'O', '\0',
            'X', '\0', 'O'
        };

        BoardPrinter printer = new BoardPrinter();
        printer.PrintBoard(board);
    }
}
