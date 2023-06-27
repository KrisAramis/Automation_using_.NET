namespace Kristina_Kulich__Application.CSharpOOP4;

public class Ball : Shape
{
    public string _name;
    public double _radius;


    public Ball(string name, double radius)
    {
        this._name = name;
        this._radius = radius;
    }

    public override void ShapeInfo()
    {
        Console.WriteLine($"{_name} has square {this.GetSquare()}");
    }

    public override double GetSquare()
    {
        return 4 * Math.PI * _radius * _radius;
    }
}