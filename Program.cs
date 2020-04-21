using System;
using System.Linq;

namespace C_SlackTaskThree
{
    class Program
    {
        static void Main(string[] args)
        {
            bool intResultTryParse = false;
            Console.WriteLine("This is a Number Guessing App");
            Console.WriteLine("Enter any number to start");
            string str = Console.ReadLine();
            int intStr;
            intResultTryParse = int.TryParse(str, out intStr);
            if (intResultTryParse == true)
            {
                switch (intStr)
                {
                    case 1:
                        PerformEasyGuess();
                        break;
                    case 2:
                        PerformMediumGuess();
                        break;
                    case 3:
                        PeformHardGuess();
                        break;
                }
            }
            else
            {
                Console.WriteLine("There are 3 levels, Easy, Medium, Hard");
                Console.WriteLine("Enter 1 for Easy, 2 for Medium, 3 for Hard ");
                if (intResultTryParse == true)
                {
                    switch (intStr)
                    {
                        case 1:
                            PerformEasyGuess();
                            break;
                        case 2:
                            PerformMediumGuess();
                            break;
                        case 3:
                            PeformHardGuess();
                            break;
                    }
                }
            }
            Console.WriteLine("Enter a number between 1-3");
        }

        public static void PerformEasyGuess()
        {
            string userInput = "";
            int userResult;
            int counter = 0;
            int maxx = 6;
            int[] bucket = { 3, 10, 8, 18, 34, 7, 2, 6, 11, 56 };
            while (counter < 6)
            {
                counter = counter + 1;
                Console.WriteLine("You are to guess a number between 1 - 10");
                userInput = Console.ReadLine();
                bool userD = int.TryParse(userInput, out userResult);

                if (bucket.Contains(userResult))
                {
                    Console.WriteLine("You guessd right. you have {0} guesses left", maxx - counter);

                }
                else
                {
                    Console.WriteLine("Try guessing again that was wrong. you have {0} guesses left", maxx - counter);
                }
            }
            Console.WriteLine("Game Over!");
        }


        public static void PerformMediumGuess()
        {
            string userInput = "";
            int userResult;
            int counter = 0;
            int maxx = 4;
            int[] bucket = { 3, 10, 8, 18, 34, 7 };
            while (counter < 4)
            {
                counter = counter + 1;
                Console.WriteLine("You are to guess a number between 1 - 20");
                userInput = Console.ReadLine();
                bool userD = int.TryParse(userInput, out userResult);

                if (bucket.Contains(userResult))
                {
                    Console.WriteLine("You guessd right. you have {0} guesses left", maxx - counter);

                }
                else
                {
                    Console.WriteLine("Try guessing again that was wrong. you have {0} guesses left", maxx - counter);
                }
            }
            Console.WriteLine("Game Over!");
        }

        private static void PeformHardGuess()
        {

            string userInput = "";
            int userResult;
            int counter = 0;
            int maxx = 3;
            int[] bucket = { 3, 78, 9, 34, 11, 56 };
            while (counter < 3)
            {
                counter = counter + 1;
                Console.WriteLine("You are to guess a number between 1 - 50");
                userInput = Console.ReadLine();
                bool userD = int.TryParse(userInput, out userResult);
                if (bucket.Contains(userResult))
                {
                    Console.WriteLine("You guessd right. you have {0} guesses left", maxx - counter);
                }
                else
                {
                    Console.WriteLine("Try guessing again that was wrong. you have {0} guesses left", maxx - counter);
                }
            }
            Console.WriteLine("Game Over!");

        }
    }
}
