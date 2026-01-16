using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string nameUser = PromptUserName();

        int numberUser = PromptUserNumber();

        int sqrNum = SquareNumber(numberUser);

        DisplayResults(nameUser, sqrNum);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;

    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string numStr = Console.ReadLine();
        int numInt = int.Parse(numStr);
        return numInt;
    }

    static int SquareNumber(int sqrNumInt)
    {
        int squared = sqrNumInt * sqrNumInt;
        return squared;
    }

    static void DisplayResults(string userName, int numSquared)
    {
        Console.WriteLine($"{userName}, the square of your number is {numSquared}.");
    }


}