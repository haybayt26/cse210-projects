



public class Bike : Activity
{
    private int _speed;

    public Bike(DateOnly date, int time, int speed) : base(date, time)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_length / 60.0) * _speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        double d = GetDistance();
        return d == 0 ? double.PositiveInfinity : _length / d;
    }




}