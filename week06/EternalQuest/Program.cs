using System;
using System.IO;


// For my extra things I made a negative goal that could be a bad habit I'm trying to stop and would take points away
// I also made it so they could delete goals

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager gM = new GoalManager();
        string input = "";

        while (true)
        {
            gM.DisplayPlayerInfo();
            Console.Write($"Menu Options:\n\t1. Create New Goal\n\t2. List Goals\n\t3. Save Goals\n\t4. Load Goals\n\t5. Record Event\n\t6. Remove Goal\n\t7. Quit\nSelect a choice from the menu: ");
            input = (Console.ReadLine()).Trim().ToLower();

            if (input.Contains("1") || input.Contains("create new"))
            {
                gM.CreateGoal();
            }
            else if (input.Contains("2") || input.Contains("list"))
            {
                gM.ListGoalDetails();
            }
            else if (input.Contains("3") || input.Contains("save"))
            {
                gM.SaveGoals();
            }
            else if (input.Contains("4") || input.Contains("load"))
            {
                gM.LoadGoals();
            }
            else if (input.Contains("5") || input.Contains("record"))
            {
                gM.RecordEvent();
            }
            else if (input.Contains("6") || input.Contains("remove"))
            {
                gM.DeleteGoal();
            }
            else if (input.Contains("7") || input.Contains("quit"))
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a correct option");
            }
        




        }

        Console.WriteLine("\nGoodbye! :D\n");

    }
}