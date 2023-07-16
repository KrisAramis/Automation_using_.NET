namespace Kristina_Kulich__Application;

    public class BikeDeveloper : IDeveloper
    {
        public IVehicle Create()
        {
            return new Bike();
        }
    }