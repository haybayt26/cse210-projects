



public class SimpleGoal : Goal
{

    public SimpleGoal(string name, string description, string points) :base(name, description, points)
    {
        
    }

    public SimpleGoal(string name, string description, string points, bool complete) :base(name, description, points, complete)
    {
        
    }

    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation() + $"|simple";
    }










}