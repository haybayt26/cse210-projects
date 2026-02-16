


public class NegativeGoal : Goal
{

    public NegativeGoal(string name, string description, string points) :base(name, description, points)
    {
        
    }

    public NegativeGoal(string name, string description, string points, bool complete) :base(name, description, points, complete)
    {
        
    }

    public override string GetDetailsString()
    {
        string details = "";
        if (!IsComplete())
        {
            details += $"[ ] {_shortName} ({_description}) -{_points} points";
        }
        else
        {
            details += $"[x] {_shortName} ({_description}) -{_points} points";
        }
        
        return details;
    }

    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation()+ $"|negative";
    }










}