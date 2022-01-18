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



            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;


                // generating a random number for the correct number

                Random random = new Random();

                int correctNumber = random.Next(1, 10); // set the random parameters and such

                // init guessed number

                int guessedNumber = 0;

                // Starting game

                Console.WriteLine("Lets play a game!");

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("Guess a number between 1 and 10");

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
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("C0RRECT0!");


                // ask User if they want to play again

                Console.WriteLine("Do you want to play again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();


                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

                // if the answer is yes you continue in the loop if not you return outside the loop and quit
            }

        }

    }
}
