using System.Runtime.CompilerServices;

namespace Kristina_Kulich__Application.CSharpOOP2;

public class Car
{
    private string _model;
    private int _productionYear = 2020;
    private static bool _diesel;
    private static bool _isOpen;
    private string _color;
    private static double _filllevel;
    private bool _engineIsRunning;
    private string _vinNumber;

    public int ProductionYear
    {
        get { return _productionYear; }
        set { _productionYear = value; }
    }

    public string Color
    {
        get { return _color;}
        set { _color = value; }
    }
    public static bool Diesel
    {
        get { return _diesel; }
        set { _diesel = value; }
    }
    
    public string Model
    {
        get { return _model; }
        set { _model = value; }
    }

    public static double FillLevel 
    {
        get{ return _filllevel; }
        set { _filllevel = value; }
    }
    public bool EngineIsRunning
    {
        get { return _engineIsRunning; }
        set { _engineIsRunning = value; }
    }
    public string VinNumber
    {
        set { _vinNumber=value; }
    }
    
    public Car()
    {
        
    }

    public Car(int productionYear)
    {
        ProductionYear = _productionYear;
    }

    public Car(string model, int productionYear, double fillLevel)
    {
        Model = model;
        ProductionYear = productionYear;
        FillLevel = fillLevel;
    }
    internal void EngineStart()
    {
        if (!EngineIsRunning&&FillLevel>0)
        {
            EngineIsRunning = true;
        }
    }
    private void EngineStop()
    {
        if (EngineIsRunning)
        {
            EngineIsRunning = false;
        }
    }

    public string ReturnModel()
    {
        return Model;
    }
    
    public static void Beep()
     {
         Console.WriteLine("Beeeeeeep");
     }

    public void ChooseColor(string color)
    {
        Color = color;
    }
}

