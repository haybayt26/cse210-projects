


public class List : Activity
{
    private int _answerCount = 0;
    private List<string> _prompts = new List<string>();

    public List() :base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        
    }


    public void RunList()
    {
        GetWelcomeMessage();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        AddInformation();
        Console.Clear();
        Console.Write("Get Ready... ");
        GetSpinner(2);
        GetListingPrompt();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _answerCount += 1;
            
        }

        Console.WriteLine($"\nYou listed {_answerCount} items!");

        GetPumpUpMessage();
    }

    private void AddInformation()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

    }

    public void GetListingPrompt()
    {
        
        int index = _random.Next(_prompts.Count);
        Console.Clear(); 
        Console.Write($"\nList as many responses you can to the following prompt:\n\n--- {_prompts[index]} ---\n\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Write("You may begin in: ");
        GetCountdown(2);
        Console.WriteLine();
        
    }
}