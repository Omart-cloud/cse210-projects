public class Rectangle : Shapes
private double side;

public Square(string color, double width, double height) :base(color)
{
    _width = width;
    _height = height; 
}

public override double GetArea();
{
    return _width * _height;
}



