using Kristina_Kulich__Application;
using Kristina_Kulich__Application.CSharpCollections1;
using Kristina_Kulich__Application.CSharpOOP2;
using Kristina_Kulich__Application.CSharpOOP4;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;

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
        Car mercedes = new Car("AMG", 2018, true, 10);

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
        //will uncomment this code later. It's used in other homework
        /*#region Ierarchy classes exemplares
        Cylinder cyl = new Cylinder("cylinder", 23, 10);
        cyl.ShapeInfo();
        Ball smallBall = new Ball("ball", 10);
        smallBall.ShapeInfo();
        Pyramid egiptPyramid = new Pyramid("Faraoh", 10, 10);
        var pyramidHeight = egiptPyramid._height;
        #endregion
        egiptPyramid.ShapeInfo();
        */

        #region Separate massive into 2
        
        int[] numbers = new[] { 1, 3, 3, 17, 8, 6, 7 };

        Collections.CalculateMassiveLength(numbers);
        Collections.DevideInEvenUnevenMassives(numbers);
        #endregion

        #region Find Difference Max Min in Array

        Collections.FindDifferenceMaxMin(numbers);

        #endregion

        #region Sort Lastnames

        List<string> lastnames = new List<string> { "Brouka", "Karatkevich", "Yulivan", "Sibebbry", "Anilevicz" };
        Collections.SortLastnames(lastnames);
        #endregion

        #region Citizens
        List<Citizen> citizensofBobruisk = new List<Citizen>();
            citizensofBobruisk.Add(new Citizen()
            {
                LastnameNameFathername = "Malinowski Henric Vladzimiravich", HomeAddress = "Malinava 24",
                BirthDate = new(2011, 6, 10)
            });
            citizensofBobruisk.Add(new Citizen()
            {
                LastnameNameFathername = "Macej Grink Aliaksandravich", HomeAddress = "Hrusheva 84",
                BirthDate = new(1991, 3, 8)
            });
            citizensofBobruisk.Add(new Citizen()
            {
                LastnameNameFathername = "Teodorovich Jupiter Vasily", HomeAddress = "Malinava 4",
                BirthDate = new(2001, 2, 10)
            });
            citizensofBobruisk.Add(new Citizen()
            {
                LastnameNameFathername = "Slimov James Adamovich", HomeAddress = "Malinava 4",
                BirthDate = new(2015, 6, 10)
            });
            citizensofBobruisk.Add(new Citizen()
            {
                LastnameNameFathername = "Girov Henry Iosifovich", HomeAddress = "Malinava 4",
                BirthDate = new(1991, 6, 10)
            });
            citizensofBobruisk.Add(new Citizen()
            {
                LastnameNameFathername = "Strepov Konrad Borisovich", HomeAddress = "Malinava 4",
                BirthDate = new(1991, 4, 10)
            });

           
            //tried to do with extencion but don't know how to call it later
            //List<Citizen> malinava4 = 
             //citizensofBobruisk.Where(citizensofBobruisk => (citizensofBobruisk.HomeAddress == "Malinava 4")).ToList().OrderBy(citizensofBobruisk => citizensofBobruisk.LastnameNameFathername);
            
            citizensofBobruisk.Where(HomeAddress => HomeAddress.Equals("Malinava 24"));
            var query = from citizen in citizensofBobruisk
                where citizen.HomeAddress.Equals("Malinava 4") && DateTime.Today.Year - citizen.BirthDate.Year >=18
                orderby citizen.LastnameNameFathername
                select citizen;
            List<Citizen> votersMalinava4 = query.ToList();

            foreach (var citizen in query)
            {
                Console.WriteLine("{0} - {1}", citizen.LastnameNameFathername, citizen.BirthDate);
            }

            #endregion*/

        #region Dictionary
            System.Console.WriteLine("Write 5 City-Country combinations in following format: Country:Capital City");
            string[] InputCountries = Console.ReadLine().Split(' ');

            CapitalCities europeCities = new CapitalCities();
            Dictionary<string, string> dict = europeCities.CreateDictionary(InputCountries);
            europeCities.ReturnCountriesCapitals(dict);
            europeCities.ReturnCapitalsCountries(dict);
            #endregion
        }
    }
