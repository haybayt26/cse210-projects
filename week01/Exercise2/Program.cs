using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string strGrade = Console.ReadLine();
        int intGrade = int.Parse(strGrade);
        string letter = "";
        if (intGrade >= 90)
        {
            letter = "A";
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else if (intGrade < 90 && intGrade >= 80)
        {
            letter = "B";
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else if (intGrade < 80 && intGrade >= 70)
        {
            letter = "C";
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else if (intGrade < 70 && intGrade >= 60)
        {
            letter = "D";
            Console.WriteLine("Better luck next time!");
        }
        else
        {
            letter = "F";
            Console.WriteLine("Better luck next time!");
        }
        Console.WriteLine($"For {intGrade}% you get a {letter}");

    }
}