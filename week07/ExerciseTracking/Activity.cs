


public class Activity
{
    private DateOnly _date;
    protected int _length;

    public Activity(DateOnly date, int time)
    {
        _date = date;
        _length = time;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_length} mins) - Distance: {GetDistance():F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min/mile";
    }



}