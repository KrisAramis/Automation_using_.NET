namespace Kristina_Kulich__Application;

public class Bus : IVehicle
{
    // Конкретные продукты содержат код различных продуктов. Продукты будут отличаться реализацией, но интерфейс у них будет общий.
    public void GetInfo()
    {
        Console.WriteLine("This is a Bus");
    }
}