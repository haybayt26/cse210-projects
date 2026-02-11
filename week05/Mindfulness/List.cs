


public class List
{
    private int _answerCount;
    private List<string> _prompts = new List<string>();


    public void RunList()
    {
        
    }

    public string GetListingPrompt()
    {
        return "Will be returning Prompt here :)";
    }

    public List<string> AnswerAmount()
    {
        return _prompts;
    }
}