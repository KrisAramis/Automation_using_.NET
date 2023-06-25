using Kristina_Kulich__Application;
using Kristina_Kulich__Application.CSharpOOP2;

class Program
{
    static void Main(string[] args)
    {
        #region create first example of Car object
        Car nissan = new Car();
        nissan.Model = "micra";
        nissan.Diesel = false;
        nissan.ProductionYear = 2010;
        #endregion
        
        #region create second example of Car object
        Car porshe = new Car() { ProductionYear = 2021, Diesel = true, Model = "911" };
        #endregion

        #region create example of Car object with constructors
        Car geely = new Car();
        Car mazda = new Car(2021);
        Car mercedes = new Car("AMG", 2018, true,10);
        #endregion

        #region call method for any car
        mercedes.Refuel(30);
        #endregion

        #region call private method
        //Mazda.EngineStop(); ErrorLine >Cannot access private method here
        #endregion

        #region call internal method
        porshe.EngineStart();
        #endregion

        #region call method when field is null
        Car matiz = new Car();
        matiz.Refuel(40); // no error, by default Filllevel was 0;
        Console.WriteLine(matiz.FillLevel); // no error, by default Model was null
        Console.WriteLine(matiz.ReturnModel());
        #endregion
        
        #region Return field with predetermined value without declaring it
        Car Chevrolet = new Car();
        Console.WriteLine(Chevrolet.ProductionYear);
        #endregion

        #region set value for private property

        mazda.VinNumber = "ANZ234BB23432000003";
        //Mazda.EngineIsRunning = true; Errorline: The property "EngineIsRunning" cannot be used in this context because the set accessor is inaccessible
        //Mazda.VinNumber; Errorline: The property "VinNumber" cannot be used in this context because the get accessor is inaccessible
        bool Carstate = mazda.EngineIsRunning;
        #endregion

        #region StaticProperty
        Car.Beep();
        Car.IsOpen = true;
        #endregion

        #region StaticMethod
        Car.RepaintCar(matiz);
        #endregion
    }
}
