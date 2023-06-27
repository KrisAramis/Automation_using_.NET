namespace Kristina_Kulich__Application.CSharpOOP4;

public class Cylinder:Shape
{
    public string _name;
    public double _radius;
    public double _height;

    public Cylinder(string name, double height, double radius)
    {
        _name = name;
        _height = height;
        _radius = radius;
    }

    public override double GetSquare()
    {
        return _height * Math.PI * _radius * _radius;
    }

    public override void ShapeInfo()
    {
        Console.WriteLine($"{_name} has square {this.GetSquare()}");
    }
}