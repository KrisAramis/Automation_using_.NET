using Kristina_Kulich__Application;
using Kristina_Kulich__Application.CSharpCollections1;
using Kristina_Kulich__Application.CSharpOOP2;
using Kristina_Kulich__Application.CSharpOOP4;

using System;
using System.Collections;

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

        /*#region Ierarchy classes exemplares
        Cylinder cyl = new Cylinder("cylinder", 23, 10);
        cyl.ShapeInfo();
        Ball smallBall = new Ball("ball", 10);
        smallBall.ShapeInfo();
        Pyramid egiptPyramid = new Pyramid("Faraoh", 10, 10);
        var pyramidHeight = egiptPyramid._height;
        #endregion
        egiptPyramid.ShapeInfo();*/

        #region Separate massive into 2

        Collections coll = new Collections();
        //coll.FillEvenNumbersMassive(); have error

        #endregion

        /*#region Sort Lastnames
        coll.SortLastnames();
        #endregion*/

       // #region Citizens

        /*{
            List<Citizen> citizensofBobruisk = new List<Citizen>();
            citizensofBobruisk.Add(new Citizen(){LastnameNameFathername = "Malinowski Henric Vladzimiravich", HomeAddress = "Malinava 24", BirthDate = new(2011,6,10)});
            citizensofBobruisk.Add(new Citizen(){LastnameNameFathername = "Macej Grink Aliaksandravich", HomeAddress = "Hrusheva 84", BirthDate = new(1991,6,10)});
            citizensofBobruisk.Add(new Citizen(){LastnameNameFathername = "Teodorovich Jupiter Vasily", HomeAddress = "Malinava 4", BirthDate = new(2001,6,10)});

            void SortCitizensAlphabetically()
            {
                IEnumerable<string> query = from citizen in citizensofBobruisk
                    orderby citizen.LastnameNameFathername
                    select citizen.LastnameNameFathername;
  
                foreach (string citizen in query) 
                Console.WriteLine(citizen);  
            }
            Console.WriteLine(citizensofBobruisk.Where(HomeAddress => HomeAddress.Equals("Malinava 24")).ToList());
        }
        #endregion*/
        int[] numbers = new[] {1,2,3,4,5,6,7 };

        //Collections.calculateMassiveLength(numbers);
        //coll.DevideInEvenUnevenMassives(numbers);
        
        #region Task

        //1. Make all cities names start with capitalized letter. Use extension and query syntax
        //2. Create City class with property Name. Using Select make list of City objects

        #endregion

        #region Dictionary 
        System.Console.WriteLine("Write 5 City-Country combinations in following format: Country:Capital City");
        string[] InputCountries = Console.ReadLine().Split(' ');
        string[] Countries = new string[InputCountries.Length];
        for (int i = 0; i < InputCountries.Length; i++)
        {
            Countries[i]=InputCountries[i].Substring(0,InputCountries[i].IndexOf(':'));
            Console.WriteLine(Countries[i]);
        }
        string[] Cities = new string[InputCountries.Length];
        for (int i = 0; i < InputCountries.Length; i++)
        {
            Cities[i]=InputCountries[i].Substring(InputCountries[i].IndexOf(':')+1);
            Console.WriteLine(Cities[i]);
        }
        
        Dictionary<string, string> CountryCapitalCity = new Dictionary<string, string>();
git 
        for (int i = 0; i < InputCountries.Length; i++)
        {
            CountryCapitalCity.Add(Countries[i], Cities[i]); 
            //When I get iside by debugging get this error below
            //An IL variable is not available at the current native IP. The error code is CORDBG_E_IL_VAR_NOT_AVAILABLE, or 0x80131304.
        }

        foreach (KeyValuePair<string, string> kvp in CountryCapitalCity)
        {
            //CountryCapitalCity.Add();
            Console.WriteLine($"Key = {0}, Value = {1}",  kvp.Key, kvp.Value);
        }
        #endregion
    }
}
