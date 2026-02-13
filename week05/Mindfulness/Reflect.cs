


public class Reflect : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public Reflect() :base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        
    }

    public void RunReflect()
    {
        GetWelcomeMessage();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        AddInformation();
        Console.Clear();
        Console.Write("Get Ready... ");
        GetSpinner(2);
        GetReflectionPrompt();

        while (DateTime.Now < endTime)
        {
            GetQuestion();
            if (_questions.Count == 0)
            {
                Console.WriteLine("No questions left");
                break;
            }
        }

        GetPumpUpMessage();
    }

    public void GetReflectionPrompt()
    {
        int index = _random.Next(_prompts.Count);
        Console.Clear();
        Console.WriteLine($"Consider the following prompt:\n\n--- {_prompts[index]} ---\n\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Clear();
        Console.Write("Now ponder on each of the following questions as they related to this experience.\nYou may begin in: ");
        GetCountdown(2);
        
        
    }

    private void AddInformation()
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");


    }

    public void GetQuestion()
    {
        
        int index = _random.Next(_questions.Count);
        Console.Write($"\n> {_questions[index]}  ");
        GetInfiniteSpinner();
        _questions.RemoveAt(index);
        
    }

}