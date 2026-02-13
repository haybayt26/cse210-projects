


public class Breathe : Activity
{
    public Breathe() :base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        
    }



    public void RunBreathe()
    {
        GetWelcomeMessage();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        Console.Clear();
        Console.Write("Get Ready... ");
        GetSpinner(2);

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreath In... ");
            GetCountdown(4);

            Console.Write("Breath Out... ");
            GetCountdown(4);

        }

        GetPumpUpMessage();


    }
}