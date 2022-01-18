using System;

namespace NumberGuesser
{   // Main Class
    class Program
    {
        // Entry point of your main method
        static void Main(string[] args)
        {

            // Set up app vars

            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Mel Incögnito";

            // Change TextColor
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Write out App info

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Change Text color again
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;

                // Setting correct number

                // int correctNumber = 7;

                // generating a random number for the correct number

                Random random = new Random();

                int correctNumber = random.Next(1, 10); // set the random parameters and such


                // Starting game

                Console.WriteLine("Lets play a game!");

                Console.ForegroundColor = ConsoleColor.Yellow;


                // init guessed number

                int guessedNumber = 0;

                Console.WriteLine("Guess the number I'm thinking.");
                Console.WriteLine("It's between 1 and 10");
                Console.ResetColor();

                // ask user for number

                while (guessedNumber != correctNumber)
                {
                    string userInput = Console.ReadLine();

                    //Making sure that your input is a number

                    if (!int.TryParse(userInput, out guessedNumber))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Type a valid number");

                        Console.ResetColor();
                        // have to add continue for it to loop around or the app will just crash
                        continue;
                    }

                    // Cast to Int and put in guess

                    guessedNumber = Int32.Parse(userInput);

                    // match guess to the correct number

                    if (guessedNumber != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Try Again!");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Exactly Right!");
                    }

                }

            }

        }
    }
}
