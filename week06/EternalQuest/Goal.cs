



public class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;
    protected bool _isComplete;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public Goal(string name, string description, string points, bool complete)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _isComplete = complete;
    }

    public virtual void RecordEvent()
    {
        _isComplete = true;

    }

    public virtual int GetScore()
    {
        return int.Parse(_points);
    }

    public virtual bool IsComplete()
    {
        return _isComplete;
    }

    public virtual string GetDetailsString()
    {
        string details = "";
        if (!IsComplete())
        {
            details += $"[ ] {_shortName} ({_description}) {_points} points";
        }
        else
        {
            details += $"[x] {_shortName} ({_description}) {_points} points";
        }
        
        return details;
    }

    public virtual string GetNamesString()
    {
        string details = "";
        if (!IsComplete())
        {
            details += $"[ ] {_shortName}";
        }
        else
        {
            details += $"[x] {_shortName}";
        }
        
        return details;
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_shortName}|{_description}|{_points}|{_isComplete}";
    }









}