namespace Kristina_Kulich__Application.CSharpOOP4;

public class Pyramid:Shape
{
    public double _height;
    public double _s;

    public Pyramid(string name, double height, double bottomsquare):base(name)
    {
        _height = height;
        _s = bottomsquare;
    }

    public override void ShapeInfo()
    {
        Console.WriteLine("Area of {0}   = {1:F2}",Name, this.GetSquare());
    }
    public override double GetSquare()
    {
        return 0.5 * _height * _s;
    }
}