using System;

namespace NumberGuesser
{   // Main Class
    class Program
    {
        // Entry point of your main method
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser();

            while (true)
            {

                // generating a random number for the correct number

                Random random = new Random();

                int correctNumber = random.Next(1, 10); // set the random parameters and such

                // init guessed number

                int guessedNumber = 0;

                // Starting game

                PrintColorMessage(ConsoleColor.Green, "Guess a number between 1 and 10");

                // ask user for number

                while (guessedNumber != correctNumber)
                {
                    string userInput = Console.ReadLine();

                    //Making sure that your input is a number

                    if (!int.TryParse(userInput, out guessedNumber))
                    {

                        PrintColorMessage(ConsoleColor.Red, "Please type a real number");

                        // have to add continue for it to loop around or the app will just crash
                        continue;
                    }

                    // Cast to Int and put in guess

                    guessedNumber = Int32.Parse(userInput);

                    // match guess to the correct number

                    if (guessedNumber != correctNumber)
                    {

                        PrintColorMessage(ConsoleColor.Red, "Not quite! Try Again!");

                    }
                }


                PrintColorMessage(ConsoleColor.Yellow, "Correct!");


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

        static void GetAppInfo()
        {
            // Set up app vars

            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Mel Incögnito";

            // Change TextColor

            PrintColorMessage(ConsoleColor.DarkMagenta, $"{appName}: Version {appVersion} written by {appAuthor}");

        }

        static void GreetUser()
        {

            PrintColorMessage(ConsoleColor.Yellow, "Enter your name: ");

            string userName = Console.ReadLine();

            PrintColorMessage(ConsoleColor.Cyan, $"Welcome {userName}, let's play a game!");

        }


        // function to print colored message

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }


    }

}
