



public class Swim : Activity
{
    private int _numOfLaps;

    public Swim(DateOnly date, int time, int laps) : base(date, time)
    {
        _numOfLaps = laps;
    }

    public override double GetDistance()
    {
        return (_numOfLaps * 50.0 / 1000.0 * 0.62);
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _length) * 60.0;
    }

    public override double GetPace()
    {
        double d = GetDistance();
        return d == 0 ? double.PositiveInfinity : _length / d;
    }




}