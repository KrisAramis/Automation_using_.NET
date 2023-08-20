using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using Kristina_Kulich__Application;
using Kristina_Kulich__Application.Helper;
using Kristina_Kulich__Application.CSharpLinq;
﻿using System.Text.Unicode;
using Kristina_Kulich__Application;
using Kristina_Kulich__Application.CSharpOOP2;
using Kristina_Kulich__Application.CSharpBasics3;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 4, 0, 8, 22 };
        
        int firstNumber = FlowerHelper.ReturnFirstElement(numbers);
        Console.WriteLine("First number is: {0}", firstNumber);

        Rose blueRose = new Rose() { Price = 10, Name = "Blue Rose", Color = "blue" };
        Camomile swissCamomile = new Camomile() { Price = 10, Name = "Swiss Camomile", Color = "yellow-white" };
        int rosesAmount = 0;
        int camomilesAmount = 0;
        Console.WriteLine("Input roses amount:");
        bool success = int.TryParse(Console.ReadLine(), out rosesAmount);
        Console.WriteLine("Input camomiles amount:");
        bool success2 = int.TryParse(Console.ReadLine(), out camomilesAmount);

        double bouqetPrice = FlowerHelper.ReturnPriceforBouquet(blueRose, rosesAmount);
        double bouqetPrice2 = FlowerHelper.ReturnPriceforBouquet(swissCamomile, camomilesAmount);
        
        FlowerHelper.PrintReceipt(swissCamomile, camomilesAmount);
        FlowerRepaint<Flower>.RepaintFlower(blueRose, "black");
        FlowerHelper.PrintReceipt(blueRose, rosesAmount);
        Car chevrolet = new Car("matiz",2009, 50);
        chevrolet.ReturnCarInfo();
        chevrolet.SetVinNumber();
        chevrolet.RepaintCar("grey");
        chevrolet.StopEngine();
        chevrolet.Refuel(39);

      #region Task1

        int[] integers = new[] { 12, 8, 27, 78, 2, 3, 3, 4, 21, 1 };

        var divedsby3 = from m in integers
            where m % 3 == 0
            select m;
        foreach (var v in divedsby3)
        {
            Console.WriteLine("Devides by 3 without remainder: {0}", v);
        }

        #endregion

        #region Task2

        int[] integers2 = new[] { 15, -8, -7, -5, 6, 14, 13, -9, 11, -10 };
        List<int> lesser10andnegative = integers2.Where(i => i < 10).ToList();
        foreach (var v in lesser10andnegative)
        {
            Console.WriteLine("Less than 10 and negative: {0}", v);
        }

        #endregion

        #region Task3

        List<string> brands = new List<string> { "chanel", "dior", "gucci", "stella mccartni", "adidas" };
        var filteredbrands = from b in brands
            where Helper.CheckIfIsDevidedWithoutRamainder(b.Length, 2) == true
            orderby b
            select b;
        foreach (var v in filteredbrands)
        {
            Console.WriteLine("Brands have even length: {0}", v);
        }

        #endregion

        #region Task4

        string brandStartsWithLetter = "B";
        string brandEndsWithLetter = "k";

        List<string> cities = new List<string>() { "Berlin", "London", "Paris", "Bobruisk", "Tokyo" };
        var citiesfiltered = cities.Where(i => i.StartsWith("brandStartsWithLetter") && i.EndsWith("brandEndsWithLetter")).ToList();

        foreach (var g in citiesfiltered)
        {
            Console.WriteLine("City of dream is {0}", g);
        }

        #endregion

        #region Task5

        //couldn't solve, here my drafts

        Console.WriteLine("input string with words in different case");
        string allstring = Console.ReadLine();
        var listOfWords = allstring.Split(new char[]{' '}).ToList();
        var uppareCaseWords = listOfWords.Where(word => word.All(char.IsUpper));
        foreach (var s in uppareCaseWords)
        {
            Console.WriteLine($"Upper case words are: {s}");
        }
        
        #endregion

        #region Task6

        //couldn't solve yet, here drafts
        int[] integers3 = new[] { 15, 4, -7, 15, -7, 14, 13, 4, 11, 15 };
        var onlydistinct = integers3.Distinct().Reverse().ToList();
        foreach (var u in onlydistinct)
        {
            Console.WriteLine(u);
        }

        #endregion


        #region Task7

        int userinput = 0;
        int.TryParse(Console.ReadLine(),out userinput);
        bool checkIfinMassive = IsTheNumberInMassive(userinput,integers);
        Console.WriteLine($"Is  in massive?: {checkIfinMassive}");

        #endregion

        #region Task8

        List<string> twocolor = new List<string>();

        List<string> tricolor = new List<string>() { "#FFFFFF", "FF0000", "#FFFFFF", "unknown" };
        var listLength = tricolor.Sum(list => list.Length);
        if (listLength > 5)
        {
         Console.WriteLine("The first and last element's of the list are: {0}, {1}", tricolor.First(), tricolor.Last());   
        }
        
        #endregion

        #region Task9

        IList<Student> studentList = new List<Student>()
        {
            new Student() { StudentID = 1, StudentName = "John", Grade = 1, StandardID = 1 },
            new Student() { StudentID = 2, StudentName = "Steve", Grade = 2, StandardID = 1 },
            new Student() { StudentID = 3, StudentName = "Bill", Grade = 3, StandardID = 2 },
            new Student() { StudentID = 4, StudentName = "Ram", Grade = 3, StandardID = 2 },
            new Student() { StudentID = 5, StudentName = "Ron", Grade = 2 }
        };

        var studentGrades = studentList.Select(s => s.Grade).ToList();
        List<Student> secondgrade = new List<Student>();
        secondgrade.Add(new Student(){StudentID = 4, StudentName = "Ram", Grade = studentGrades[1], StandardID = 2 });
        secondgrade.Add(new Student(){StudentID = 4, StudentName = "John", Grade = studentGrades[1], StandardID = 2 });
        secondgrade.Add(new Student(){StudentID = 4, StudentName = "Arthur", Grade = studentGrades[1], StandardID = 2 });
        secondgrade.Add(new Student(){StudentID = 4, StudentName = "James", Grade = studentGrades[1], StandardID = 2 });
        secondgrade = secondgrade.Where(s => s.Grade == 2).ToList();
        foreach (var a in secondgrade )
                Console.WriteLine("This student is from second grade:{0}", a.StudentName);
        
        #endregion

        #region Task9

        List<Student> internationalStudents = new List<Student>();
        internationalStudents.Add(new Student(){StudentID = 4, StudentName = "Ram", Grade = studentGrades[0], StandardID = 2 });
        internationalStudents.Add(new Student(){StudentID = 4, StudentName = "John", Grade = studentGrades[1], StandardID = 2 });
        internationalStudents.Add(new Student(){StudentID = 4, StudentName = "Arthur", Grade = studentGrades[2], StandardID = 2 });

        var gradesOfInternationalStudents = internationalStudents.Select(i => i.Grade);
        foreach (var k in gradesOfInternationalStudents)
        {
            Console.WriteLine($"These are the the grades:{k}");
        }

        #endregion
    }
    
    public static bool IsTheNumberInMassive(int userinput, int[] integers)
    {
        return integers.Contains(userinput);
    }
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