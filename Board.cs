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
        // Method to print the Tic-Tac-Toe board
        public void PrintBoard(char[] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                // Print the current cell value or a placeholder for empty cells
                char cell = board[i] == '\0' ? ' ' : board[i];
                Console.Write($" {cell} ");

                // Add a vertical separator for all but the last column
                if ((i + 1) % 3 != 0)
                {
                    Console.Write("|");
                }
                else if (i < 8)
                {
                    // Add a horizontal separator for all but the last row
                    Console.WriteLine("\n---+---+---");
                }
            }
            Console.WriteLine(); // Move to the next line after the grid
        }
        public string CheckVictory(string[] grid)
        {
            // Check rows
            if (grid[0] == grid[1] && grid[1] == grid[2]) return grid[0];
            if (grid[3] == grid[4] && grid[4] == grid[5]) return grid[3];
            if (grid[6] == grid[7] && grid[7] == grid[8]) return grid[6];

            // Check columns
            if (grid[0] == grid[3] && grid[3] == grid[6]) return grid[0];
            if (grid[1] == grid[4] && grid[4] == grid[7]) return grid[1];
            if (grid[2] == grid[5] && grid[5] == grid[8]) return grid[2];

            // Check diagonals
            if (grid[0] == grid[4] && grid[4] == grid[8]) return grid[0];
            if (grid[2] == grid[4] && grid[4] == grid[6]) return grid[2];

            // No winner
            return null;
        }
        public string GameWinner(string[] grid)
        {
            // Check for a winner
            string winner = CheckVictory(grid);
            if (winner != null)
            {
                // Return the winner as Player 1 (X) or Player 2 (O)
                return winner == "X" ? "Player 1 wins!" : "Player 2 wins!";
            }

            // Check for a draw (no empty cells remaining)
            if (!grid.Any(cell => cell != "X" && cell != "O"))
            {
                return "It's a draw!";
            }

            // Game is still ongoing
            return "No winner yet.";
        }

    }

}

