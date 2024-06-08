namespace GuessANumber
{
    internal class GuessANumber
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int computerNumber = randomNumber.Next(1, 101);

            while (true)
            {
                Console.Write("Guess a number (1-100): ");

                string playerInput = Console.ReadLine();
                int playerGuess;
                bool isValid = int.TryParse(playerInput, out playerGuess);

                if (isValid)
                {
                    if (playerGuess == computerNumber)
                    {
                        Console.WriteLine("You guessed it!");
                        break;
                    }
                    else if (playerGuess > computerNumber)
                    {
                        Console.WriteLine("Too High");
                    }
                    else if (playerGuess < computerNumber)
                    {
                        Console.WriteLine("Too Low");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
        }
    }
}
