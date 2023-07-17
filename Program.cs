// See https://aka.ms/new-console-template for more information

using Kristina_Kulich__Application;
using Kristina_Kulich__Application.CSharpOOP2;
using Kristina_Kulich__Application.CSharpBasics3;

class Program
{
    static void Main(string[] args)
    {
        #region create first example of Car object
        Car Nissan = new Car();
        Nissan.Model = "micra";
        Nissan.Diesel = false;
        Nissan.ProductionYear = 2010;
        #endregion
        
        #region create second example of Car object
        Car Porshe = new Car() { ProductionYear = 2021, Diesel = true, Model = "911" };
        #endregion

        #region create example of Car object with constructors
        Car Geely = new Car();
        Car Mazda = new Car(2021);
        Car Mercedes = new Car("AMG", 2018, true,10);
        #endregion

        #region call method for any car
        Mercedes.Refuel(30);
        #endregion

        #region call private method
        //Mazda.EngineStop(); ErrorLine >Cannot access private method here
        #endregion

        #region call internal method
        Porshe.EngineStart();
        #endregion

        #region call method when field is null
        Car Matiz = new Car();
        Matiz.Refuel(40); // no error, by default Filllevel was 0;
        Console.WriteLine(Matiz.FillLevel); // no error, by default Model was null
        Console.WriteLine(Matiz.ReturnModel());
        #endregion
        
        #region Return field with predetermined value without declaring it
        Car Chevrolet = new Car();
        Console.WriteLine(Chevrolet.ProductionYear);
        #endregion
    }
}
