namespace Kristina_Kulich__Application.CSharpOOP4;

public class Ball : Shape
{
    private double _radius;
    
    public Ball(string name, double radius):base(name)
    {
        this._radius = radius;
    }

    public override void ShapeInfo()
    {
        Console.WriteLine("Area of {0}   = {1:F2}",Name, this.GetSquare());
    }

    public override double GetSquare()
    {
        return 4 * Math.PI * _radius * _radius;
    }
}