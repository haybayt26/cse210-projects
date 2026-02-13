using System;

// It isn't much but I did make it so that if they typed the activity name instead of the number it wouldn't crash.
// I made it so there weren't any repeat questions on activity 2
// I also made 2 types of spinners so people can't spam enter to get out of them.
class Program
{
    static void Main(string[] args)
    {

        Activity activity = new Activity();
        string input = "";
        while (true)
        {
            Console.Clear();
            Console.Write($"Menu Options:\n\t1. Start Breathing Activity\n\t2. Start Reflecting Activity\n\t3. Start Listing Activity\n\t4. Quit\nSelect a choice fromm the menu: ");
            input = (Console.ReadLine()).Trim().ToLower();

            if (input.Contains("1") || input.Contains("breath"))
            {
                Breathe breathe = new Breathe();
                breathe.RunBreathe();
            }
            else if (input.Contains("2") || input.Contains("reflect"))
            {
                Reflect reflect = new Reflect();
                reflect.RunReflect();
            }
            else if (input.Contains("3") || input.Contains("list"))
            {
                List list = new List();
                list.RunList();
            }
            else if (input.Contains("4") || input.Contains("quit"))
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