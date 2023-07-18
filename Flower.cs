namespace Kristina_Kulich__Application;

public class Flower
{
    double _price;
    private string _name;
    private string _color;
    
    public double Price
    {
        get => _price;
        set => _price = value;
    }

    public string Color
    {
        get => _color;
        set => _color = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }
}