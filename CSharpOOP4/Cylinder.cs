namespace Kristina_Kulich__Application.CSharpOOP4;

public class Cylinder:Shape
{
    public double _radius;
    
    public double _height;
    
    
    public Cylinder(string name, double height, double radius):base(name)
    {
        _height = height;
        _radius = radius;
    }

    public override double GetSquare()
    {
        return _height * Math.PI * _radius * _radius;
    }

    public override void ShapeInfo()
    {
        Console.WriteLine("Area of {0}   = {1:F2}",Name, this.GetSquare());
    }
}