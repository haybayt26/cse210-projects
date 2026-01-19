using System;
using System.Collections.Generic;

using System.IO;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Entry.GeneratePrompts();
        Menu menu = new Menu();

        while (menu._write == true)
        {
            menu.ShowMenu();
            menu.MenuChoice();
        }
    }
}
