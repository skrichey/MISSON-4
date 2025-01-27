using System;
using System.Linq;

namespace Mission_4
{
    internal class BoardPrinter
    {
        // Method to print the Tic-Tac-Toe board
        public void PrintBoard(string[] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                Console.Write($" {board[i]} ");
                if ((i + 1) % 3 != 0)
                {
                    Console.Write("|");
                }
                else if (i < 8)
                {
                    Console.WriteLine("\n---+---+---");
                }
            }
            Console.WriteLine();
        }

        // Method to check for a winner
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

        // Method to determine the game result
        public string GameWinner(string[] grid)
        {
            string winner = CheckVictory(grid);
            if (winner != null)
            {
                return winner == "X" ? "Player 1 wins!" : "Player 2 wins!";
            }

            if (!grid.Any(cell => cell != "X" && cell != "O"))
            {
                return "It's a draw!";
            }

            return "No winner yet.";
        }
    }
}
