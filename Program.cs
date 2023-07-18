using System.Text.Unicode;
using Kristina_Kulich__Application;
using Kristina_Kulich__Application.CSharpOOP2;
using Kristina_Kulich__Application.CSharpBasics3;

class Program
{
    static void Main(string[] args)
    {
        #region create first example of Car object
        Car nissan = new Car();
        nissan.Model = "micra";
        nissan.ProductionYear = 2010;
        #endregion
        
        #region create second example of Car object
        Car porshe = new Car() { ProductionYear = 2021, Model = "Porshe 911" };
        #endregion

        #region create example of Car object with constructors
        Car geely = new Car();
        Car mazda = new Car(2021);
        Car mercedes = new Car("AMG", 2018,10);
        #endregion

        #region call method for any car
        porshe.ChooseColor("white");
        #endregion

        #region call private method
        //mazda.EngineStop(); ErrorLine >Cannot access private method here
        #endregion

        #region call internal method
        porshe.EngineStart();
        #endregion

        #region call method when field is null
        Car matiz = new Car();
        string colorWhenNull = matiz.Color;
        Console.WriteLine("colorwhen before set {0}", colorWhenNull);
        matiz.ChooseColor("black");
        string colorAfterCalledMethod = matiz.Color;
        Console.WriteLine("colorwhen after set {0}", colorAfterCalledMethod);

        Console.WriteLine("Call method 'Return model' when field 'model' is null: {0}", matiz.ReturnModel());
        #endregion
        
        #region Return field with predetermined value without declaring it
        Car chevrolet = new Car();
        Console.WriteLine("Predetermined field call: {0}" ,chevrolet.ProductionYear);
        #endregion

        #region set/get value for private property
        mazda.VinNumber = "ANZ234BB23432000003";
        //mazda.VinNumber; Errorline: //The property 'Kristina_Kulich__Application.CSharpOOP2.Car.VinNumber' has no getter
        //mazda.FillLevel = 40; //The property 'Kristina_Kulich__Application.CSharpOOP2.Car.FillLevel' cannot be used in this context because the 'set' accessor is inaccessible
        //double filllevel = mazda.FillLevel;
        #endregion

        #region StaticProperty
        Car.Diesel= true;// set static property
        Console.WriteLine($"Is the filter for diesel cars selected?{Car.Diesel}"); //get static property
        #endregion

        #region StaticMethod
        Car.Beep(); //call of a static method
        #endregion

        #region call of methods from Helper class
            CarHelper.RepaintCar(matiz, "red");
            CarHelper.Refuel(50);
            porshe.SetVinNumber();
            CarHelper.ReturnCarInfo(porshe);
            
        #endregion
    }
}
