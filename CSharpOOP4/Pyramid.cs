namespace Kristina_Kulich__Application.CSharpOOP4;

public class Pyramid:Shape
{
    public string _name;
    public double _height;
    public double _s;

    public Pyramid(string name, double height, double bottomsquare)
    {
        _name = name;
        _height = height;
        _s = bottomsquare;
    }

    public override void ShapeInfo()
    {
        Console.WriteLine($"{_name} has square {this.GetSquare()}");
    }
    public override double GetSquare()
    {
        return 0.5 * _height * _s;
    }
}