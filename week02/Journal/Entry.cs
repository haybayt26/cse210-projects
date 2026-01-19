using System.Collections.Generic;
using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

public class Entry
{
    public static List<string> _prompts = new List<string>();
    public string _entry;
    public string _date;
    public string _chosenPrompt;

    public static void GeneratePrompts()
    {
        _prompts.Add("What went well today, and why?");
        _prompts.Add("What's something I'm currently struggling with, and what's one small step I could take to improve it?");
        _prompts.Add("What did I learn recently (about myself or someone eles)?");
        _prompts.Add("What am I avoiding right now, and what am I afraid would happen if I faced it?");
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("If I could give my past self advice from one year ago, what would I say?");
    }

    public string LoadPrompt()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, _prompts.Count);
        _chosenPrompt = _prompts[number];
        return _chosenPrompt;

    }

    



}