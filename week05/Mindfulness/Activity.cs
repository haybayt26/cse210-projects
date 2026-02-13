



public class Activity
{
    private int _desiredTime;
    private string _name;
    private string _description;
    protected Random _random = new Random();

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public Activity()
    {
        
    }


    public void GetSpinner(int seconds)
    {
        DateTime endtime = DateTime.Now.AddSeconds(seconds);
        Console.Write("-");
        while (DateTime.Now < endtime)
        {
            Thread.Sleep(300);
            Console.Write("\b \b\\");
            Thread.Sleep(300);
            Console.Write("\b \b|");
            Thread.Sleep(300);
            Console.Write("\b \b/");
            Thread.Sleep(300);
            Console.Write("\b \b-");

        }
        
        Console.Write("\b \b \n");

    }

    public void GetInfiniteSpinner()
{
    Thread.Sleep(300);
    Console.Write("-");

    while (true)
    {
        // Check if Enter was pressed
        if (Console.KeyAvailable)
        {
            if (Console.ReadKey(true).Key == ConsoleKey.Enter)
            {
                break;
            }
        }

        Thread.Sleep(300);
        Console.Write("\b \b\\");
        Thread.Sleep(300);
        Console.Write("\b \b|");
        Thread.Sleep(300);
        Console.Write("\b \b/");
        Thread.Sleep(300);
        Console.Write("\b \b-");
    }

    Console.Write("\b \b \n");
}

    public void GetCountdown(int seconds)
    {
        DateTime endtime = DateTime.Now.AddSeconds(seconds);
        int i = seconds;
        while (DateTime.Now < endtime)
        {
            if (i == seconds)
            {
                Console.Write($"{i}");
                Thread.Sleep(1000);
                i -= 1;
            }
            else
            {
                Console.Write($"\b \b{i}");
                Thread.Sleep(1000);
                i -= 1;
            }
            
        }

        Console.Write($"\b \b \n");
    }

    public void GetWelcomeMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n{_description}");
    }

    public void GetPumpUpMessage()
    {
        Console.Write($"\nWell Done! ");
        GetSpinner(2);
        Console.Write($"\nYou have completed {_desiredTime} seconds of the {_name}. ");
        GetSpinner(3);
        Console.WriteLine();
    }   

    public void GetActivityTime()
    {
        
    }

    public int GetDuration()
    {
        while (true)
        {
            Console.Write("\nHow long, in seconds, would you like for your session? ");
            string duration = Console.ReadLine();
            if (int.TryParse(duration, out int durationInt))
            {
                _desiredTime = durationInt;
                return durationInt;
            }
            
            Console.WriteLine("Please enter valid number: ");
        }
        
    }
}