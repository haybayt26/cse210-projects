using System.Collections.Generic;
using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void LoadJournal(string fileName)
    {
        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                Entry entry = new Entry();
                entry._date = parts[0];
                entry._chosenPrompt = parts[1];
                entry._entry = parts[2];
                _entries.Add(entry);
            }
        }
    }

    public void DisplayEntries()
    {
        Console.WriteLine();
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"{entry._date}: {entry._chosenPrompt} \n{entry._entry}\n");
        }   
    }

    public void SaveJournal(string fileName)
    {
        
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._chosenPrompt}|{entry._entry}");
            }
        }
        Console.WriteLine($"Saved {_entries.Count} entries to {fileName}");
    }

    public void CreateEntry()
    {
        Entry entry = new Entry();
        string prompt = entry.LoadPrompt();
        Console.WriteLine(prompt);
        entry._entry = Console.ReadLine();
        entry._date = DateTime.Now.ToString("MM/dd/yyyy");
        _entries.Add(entry);
    }
}