namespace Kristina_Kulich__Application;
// Классы, реализующие интерфейс IDeveloper
public class TruckDeveloper : IDeveloper
{
    //Конкретные создатели по-своему реализуют фабричный метод, производя те или иные конкретные продукты.
    public IVehicle Create()
    {
        return new Truck();
    }
}