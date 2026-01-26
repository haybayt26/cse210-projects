using System;

class Program
{
    //For my extra effort I decided to have the program pull from a library of scriptures
    //They can be found under bin labeled library.txt
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        
        Scripture script = new Scripture();
        script.LoadScriptures();
        script.ChooseScripture();
    }
}