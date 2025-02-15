public class Circle : Shapes
private double side;

public Square(string color, double radius) :base(color)
{
    _radius = radius;
}

public override double GetArea();
{
    return Math.PI = _radius * _radius;
}
