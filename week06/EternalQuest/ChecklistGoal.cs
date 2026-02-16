




public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;


    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public ChecklistGoal(string name, string description, string points, bool complete, int completed, int target, int bonus) : base(name, description, points, complete)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = completed;
    }

    public override int GetScore()
    {
        if (IsComplete())
        {
            Console.WriteLine($"You completed the goal of {_shortName} {_target} times. Here is a bonus of {_bonus}!");
            return int.Parse(_points) + _bonus;
        }
        else
        {
            return base.GetScore();
        }
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted >= _target)
        {
            _isComplete = true;
        }
        else
        {
            _isComplete = false;
        }
    }



    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation() + $"|checklist|{_amountCompleted}|{_target}|{_bonus}";
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $" -- {_amountCompleted}/{_target} complete.";
    }

    public override string GetNamesString()
    {
        return base.GetNamesString() + $" -- {_amountCompleted}/{_target} complete.";
    }




}