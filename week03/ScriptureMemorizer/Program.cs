using System;

class Program
{
    //For my extra effort I decided to have the program pull from a library of scriptures
    //They can be found under library.txt
    //I also made it so that the scripture will always finish within 5 rounds and won't "hide" already hidden words
 
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        string input = "";

        
        Reference reference = new Reference();
        reference.LoadScriptures();

        
        Reference chosenScripture = reference.GetChosenScripture();
        Scripture scripture = new Scripture(chosenScripture.GetReferenceText(), chosenScripture.GetChosenVerses());

        while (input != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetFullDisplayText());
            input = Console.ReadLine();
            scripture.HideRandomWords();
        }
        
        Console.Clear();
        Console.WriteLine(scripture.GetFullDisplayText());
        Console.WriteLine("Goodbye");
    }
}