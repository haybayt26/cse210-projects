using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        bool wantToPlay = false;
        int rounds = 0;
        do
        {
            Console.Write("Magic Number Generated between 1-20");
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1,20);
            bool correct = false;
            int tries = 0;

            do
            {
                Console.WriteLine("What is your guess? ");
                string strGuess = Console.ReadLine();
                int guess = int.Parse(strGuess);
                if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess == number)
                {
                    Console.WriteLine("Correct!");
                    correct = true;
                }
                tries += 1;

            } while (correct == false);

            Console.WriteLine($"Congrats! It took you {tries} tries.");
            Console.WriteLine($"Want to play again? (y/n) ");
            string choice = Console.ReadLine();
            if (choice == "y")
            {
                wantToPlay = true;
            }
            else if (choice == "n")
            {
                wantToPlay = false;
            }
            else
            {
                Console.WriteLine("Incorrect Input");
                wantToPlay = false;
            }
            rounds += 1;

        } while (wantToPlay == true);

        Console.WriteLine($"You played {rounds} round(s), Goodbye.");
    }
    
}