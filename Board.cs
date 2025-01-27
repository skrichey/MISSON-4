using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Mission_4
{
    internal class BoardPrinter
    {
        public void PrintBoard(char[,] board)
        {
            // Iterate through the rows of the board
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    // Print the cell content or a placeholder for empty cells
                    char cell = board[row, col] == '\0' ? ' ' : board[row, col];
                    Console.Write($" {cell} ");

                    // Add a vertical separator for all but the last column
                    if (col < 2)
                    {
                        Console.Write("|");
                    }
                }

                Console.WriteLine(); // Move to the next row

                // Add a horizontal separator for all but the last row
                if (row < 2)
                {
                    Console.WriteLine("---+---+---");
                }
            }

        }
    }
}

