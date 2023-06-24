namespace Kristina_Kulich__Application.CSharpOOP2;

public class Car
{
    public string Model;
    public int ProductionYear = 2020;
    public bool Diesel;
    public double FillLevel;

    public bool EngineIsRunning { get; set; }

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
}

