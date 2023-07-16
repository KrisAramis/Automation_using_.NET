namespace Kristina_Kulich__Application;

// Интерфейс IVehicle
    public interface IVehicle
    {
      //  Продукт определяет общий интерфейс объектов, которые может произвести создатель и его подклассы.
        void GetInfo();
    }

public class BikeDeveloper : IDeveloper
    {
        public IVehicle Create()
        {
            return new Bike();
        }
    }

    

    
