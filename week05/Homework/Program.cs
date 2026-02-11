using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Assignment a1 = new Assignment("Haley Light", "C# Coding");
        Console.WriteLine(a1.GetSummary());
        
        MathAssignment a2 = new MathAssignment("Sammuel Bennet", "Multiplication", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of Warld War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());







    }
}