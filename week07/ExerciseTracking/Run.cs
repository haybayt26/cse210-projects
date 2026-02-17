


public class Run : Activity
{
    private double _distance;

    public Run(DateOnly date, int time, int distance) : base(date, time)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _length) * 60;
    }

    public override double GetPace()
    {
        double d = GetDistance();
        return d == 0 ? double.PositiveInfinity : _length / d;
    }




}