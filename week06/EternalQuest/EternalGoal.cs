



public class EternalGoal : Goal
{
    

    public EternalGoal(string name, string description, string points) :base(name, description, points)
    {
        
    }

    public EternalGoal(string name, string description, string points, bool complete) :base(name, description, points, complete)
    {
        
    }

    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation()+ $"|eternal";
    }








}