using System;

namespace Mission_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Tic-Tac-Toe game!");

            // Create the game board array
            string[] grid = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            BoardPrinter boardPrinter = new BoardPrinter();

            int numTurns = 0;
            string currentPlayer;

            // Main game loop
            while (numTurns < 9)
            {
                boardPrinter.PrintBoard(grid);
                currentPlayer = (numTurns % 2 == 0) ? "X" : "O";
                Console.WriteLine($"Player {(currentPlayer == "X" ? "1" : "2")}, it's your turn. Enter a number (1-9):");

                bool isValidInput = false;
                int userInput = 0;

                // Input validation loop
                while (!isValidInput)
                {
                    string input = Console.ReadLine();

                    // Check if the input is valid
                    if (int.TryParse(input, out userInput) && userInput >= 1 && userInput <= 9)
                    {
                        if (grid[userInput - 1] != "X" && grid[userInput - 1] != "O")
                        {
                            isValidInput = true;
                        }
                        else
                        {
                            Console.WriteLine("That spot is already taken. Choose another number:");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Enter a number between 1 and 9:");
                    }
                }

                // Update the grid with the current player's move
                grid[userInput - 1] = currentPlayer;
                numTurns++;

                // Check for a winner
                string result = boardPrinter.GameWinner(grid);
                if (result != "No winner yet.")
                {
                    boardPrinter.PrintBoard(grid);
                    Console.WriteLine(result);
                    return; // End the game
                }
            }

            // If the loop ends without a winner, declare a draw
            boardPrinter.PrintBoard(grid);
            Console.WriteLine("It's a draw!");
        }
    }
}
