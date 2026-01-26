using System;

class Program
{
    //For my extra effort I decided to have the program pull from a library of scriptures
    //They can be found under library.txt
 
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        string input = "";


        while (input != "quit")
        {
            Reference reference = new Reference();
            reference.LoadScriptures();
            reference.ChooseScripture();
            input = Console.ReadLine();
        }
        
        Console.WriteLine("Goodbye");
    }
}