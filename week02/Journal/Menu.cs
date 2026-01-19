
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using System.Collections.Generic;
using System;
using System.IO;

public class Menu
{
    public bool _write = true;
    private Journal _journal = new Journal();



    public void ShowMenu()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
    }

    public void MenuChoice()
    {
        string _choice = Console.ReadLine();
        if (_choice == "1")
        {
            _journal.CreateEntry();
        }
        else if (_choice == "2")
        {
            _journal.DisplayEntries();
        }
        else if (_choice == "3")
        {
            Console.Write("What is the filename? ");
            string fileName = Console.ReadLine();
            _journal.LoadJournal(fileName);
        }
        else if (_choice == "4")
        {
            Console.Write("What is the filename? ");
            string fileName = Console.ReadLine();
            _journal.SaveJournal(fileName);
        }
        else if (_choice == "5")
        {
            _write = false;
            Console.WriteLine("Goodbye!");
        }
        else
        {
            Console.WriteLine("Please select a valid option.");
        }
    }

}