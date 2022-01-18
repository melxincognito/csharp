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

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            // Setting correct number

            int correctNumber = 7;

            Console.WriteLine("Lets play a game!");

            Console.ForegroundColor = ConsoleColor.Yellow;

            

            // init guessed number

            int guessedNumber = 0;

            Console.WriteLine("Guess the number I'm thinking.");
            Console.WriteLine("It's between 1 and 10");

            // ask user for number

            while(guessedNumber != correctNumber)
            {
                string userInput = Console.ReadLine();

                // Cast to Int and put in guess

                guessedNumber = Int32.Parse(userInput);

                // match guess to the correct number

                if(guessedNumber != correctNumber)
                {
                    Console.WriteLine("Try Again!");
                } else
                {
                    Console.WriteLine("Exactly Right!");
                }

            }

           
           

            
       
        }
    }
}
