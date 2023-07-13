namespace Kristina_Kulich__Application;

// Интерфейс IVehicle
    public interface IVehicle
    {
      //  Продукт определяет общий интерфейс объектов, которые может произвести создатель и его подклассы.
        void GetInfo();
    }

// Классы, реализующие интерфейс IVehicle
    public class Car : IVehicle
    {
        public void GetInfo()
        {
            Console.WriteLine("This is a Car");
        }
    }

    public class Bike : IVehicle
    {
        public void GetInfo()
        {
            Console.WriteLine("This is a Bike");
        }
    }

    public class Bus : IVehicle
    {
       // Конкретные продукты содержат код различных продуктов. Продукты будут отличаться реализацией, но интерфейс у них будет общий.
        public void GetInfo()
        {
            Console.WriteLine("This is a Bus");
        }
    }

    public class Truck : IVehicle
    {
        public void GetInfo()
        {
            Console.WriteLine("This is a Truck");
        }
    }

// Интерфейс IDeveloper
    public interface IDeveloper
    {
        //Создатель объявляет фабричный метод, который должен возвращать новые объекты продуктов.
        //Важно, чтобы тип результата совпадал с общим интерфейсом продуктов.
        IVehicle Create();
    }

// Классы, реализующие интерфейс IDeveloper
    public class CarDeveloper : IDeveloper
    {
       //Конкретные создатели по-своему реализуют фабричный метод, производя те или иные конкретные продукты.

       public IVehicle Create()
        {
            return new Car();
        }
    }

    public class BikeDeveloper : IDeveloper
    {
        public IVehicle Create()
        {
            return new Bike();
        }
    }

    public class BusDeveloper : IDeveloper
    {
        public IVehicle Create()
        {
            return new Bus();
        }
    }

    public class TruckDeveloper : IDeveloper
    {
        //Конкретные создатели по-своему реализуют фабричный метод, производя те или иные конкретные продукты.
        public IVehicle Create()
        {
            return new Truck();
        }
    }
