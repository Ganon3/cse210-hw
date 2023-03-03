using System;

public abstract class Shape 
{

    protected string _color;

    public string getColor() {return _color;}
    public void setColor(string color) {_color = color;}

    public abstract double getArea();
}

public class Square : Shape 
{

    double _side = 0;

    public void setSide(double side) {_side = side;}

    public override double getArea()
    {
        return _side * 4;
    }
}

public class Rectangle : Shape 
{
    double _length;
    double _width;

    public void SetLength(double length) {_length = length;}
    public void setWidth(double width) {_width = width;}

    public override double getArea()
    {
        return _length * _width; 
    }

}

public class Circle : Shape 
{
    double  _radius;

    public void setRadius(double radius) {_radius = radius;}

    public override double getArea()
    {
        return 3.1416 * _radius * 2;
    }
}