// See https://aka.ms/new-console-template for more information

using Kristina_Kulich__Application;

class Program
{
    static void Main(string[] args)
    {
        IGigantosaurus gosha = new Gigantosaurus();
        IGigantosaurus loudDecorator = new LoudGigantosarusDecorator(gosha);
        loudDecorator.Roar();
        IGigantosaurus extraLoudDecorator = new ExtraLoudGigantosaurusDecorator(gosha);
        extraLoudDecorator.Roar();
        // Создаем разработчиков
        IDeveloper carDeveloper = new CarDeveloper();
        IDeveloper bikeDeveloper = new BikeDeveloper();
        IDeveloper busDeveloper = new BusDeveloper();
        IDeveloper truckDeveloper = new TruckDeveloper();

        // Создаем объекты транспорта с использованием метода Create()
        IVehicle car = carDeveloper.Create();
        IVehicle bike = bikeDeveloper.Create();
        IVehicle bus = busDeveloper.Create();
        bus.GetInfo();
        IVehicle truck = truckDeveloper.Create();
     }
}
