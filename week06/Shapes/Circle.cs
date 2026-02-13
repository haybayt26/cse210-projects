



public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double side) :base(color)
    {
        _radius = side;
    }

    public override double GetArea()
    {
        double area = _radius * _radius * Math.PI;
        
        return area;
        
    }







}