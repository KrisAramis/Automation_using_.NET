namespace Kristina_Kulich__Application;

public class CarDeveloper : IDeveloper
{
    //Конкретные создатели по-своему реализуют фабричный метод, производя те или иные конкретные продукты.

    public IVehicle Create()
    {
        return new Car();
    }
}