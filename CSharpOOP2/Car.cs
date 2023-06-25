using System.Runtime.CompilerServices;

namespace Kristina_Kulich__Application.CSharpOOP2;

public class Car
{
    public string Model;
    public int ProductionYear = 2020;
    public bool Diesel;
    public static bool IsOpen;
    public string Color;

 
    public double FillLevel { get; private set; }
    public bool EngineIsRunning { get; private set; }
    public string VinNumber { private get; set; }
    public Car()
    {
        
    }

    public Car(int productionYear)
    {
        ProductionYear = productionYear;
    }

    public Car(string model, int productionYear, bool diesel, double fillLevel)
    {
        Model = model;
        ProductionYear = productionYear;
        Diesel = diesel;
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
        //Console.WriteLine($"Your model is {Model}");
    }
    
    public void Refuel(double liters)
    {
        FillLevel += liters;
        if(FillLevel > 60)
        {
            FillLevel = 60;
        }
    }
    public static void Beep()
     {
         Console.WriteLine("Beeeeeeep");
     }
    public static void RepaintCar(Car car, string newColor = "blue")
        {
            car.Color = newColor;
        }
}

