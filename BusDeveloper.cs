namespace Kristina_Kulich__Application;

public class BusDeveloper : IDeveloper
{
    // Классы, реализующие интерфейс IDeveloper
    public IVehicle Create()
    {
        return new Bus();
    }
}