using Mission_4;

Console.WriteLine("Welcome to the Tic-Tac-Toe game!");

// Create game board array to store players' choices
char[] Driver = new char[9] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

int numTurns = 0;
int userInput = 0;

//Ask each player in turn for their choice

while (numTurns < 9)
{
    Board.PrintBoard(Driver);
    bool isValidInput = false;

    // Determine the current player
    if (numTurns % 2 == 0)
    {
        Console.WriteLine("Player 1, please enter a number between 1 and 9 to place your X:");
    }
    else
    {
        Console.WriteLine("Player 2, please enter a number between 1 and 9 to place your O:");
    }

    // Input validation loop
    while (!isValidInput)
    {
        string input = Console.ReadLine();

        // Check if the input is a valid integer
        if (int.TryParse(input, out userInput))
        {
            // Check if the input is within range
            if (userInput >= 1 && userInput <= 9)
            {
                // Check if the position on the board is already occupied
                if (Driver[userInput - 1] != 'X' && Driver[userInput - 1] != 'O')
                {
                    isValidInput = true; // Input is valid
                }
                else
                {
                    Console.WriteLine("That spot is already taken. Please choose another number:");
                }
            }
            else
            {
                Console.WriteLine("Number is out of range. Please enter a number between 1 and 9:");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number (not a letter or special character):");
        }
        numTurns++;
    }

    // Update the game board
    if (numTurns % 2 == 0)
    {
        Driver[userInput - 1] = 'X';
    }
    else
    {
        Driver[userInput - 1] = 'O';
    }
    if (CheckVictory) = true
    {
        Console.WriteLine("Player")
    }
}


//Print the board by calling the method in the supporting class
Board.PrintBoard(Driver);

//Check for a winner by calling the method in the supporting class, and notify the players
//when a win has occurred and which player won the game

if (Board.CheckVictory(Driver))
{
    if (numTurns % 2 == 0)
    {
        Console.WriteLine("Player 1 wins!");
    }
    else
    {
        Console.WriteLine("Player 2 wins!");
    }
}
else
{
    Console.WriteLine("It's a tie!");
}

Console.WriteLine(GameWinner);