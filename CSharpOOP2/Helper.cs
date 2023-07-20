namespace Kristina_Kulich__Application.CSharpOOP2;

using System.Linq;
using System.Runtime;

public static class CarHelper
{
    public static void RepaintCar(this Car car, string newColor)
    {
        car.Color = newColor;
    }
    public static void Refuel(this Car car, double liters)
    {
        Car.FillLevel += liters;
        if(Car.FillLevel > 60)
        {
            Car.FillLevel = 60;
        }
    }

    public static void ReturnCarInfo(this Car car)
    {
        Console.WriteLine($"{car.Model} produced in {car.ProductionYear} has {car.Color} color.");
    }
    
    public static void SetVinNumber (this Car car, int length = 10)
    {
        car.VinNumber = RandomString(length);
    }

    private static Random random = new Random();

    private static string RandomString(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }

    public static void StopEngine(this Car car)
    {
        car.EngineIsRunning = false;
    }
}