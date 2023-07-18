// See https://aka.ms/new-console-template for more information

using System.Collections;
using Kristina_Kulich__Application;
using System.Linq;
using System.Collections.Generic;
using Kristina_Kulich__Application.CSharpOOP2;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 4, 0, 8, 22 };

        static T ReturnFirstElement<T>(List<T> elements)
        {
            if (elements.Count > 0)
            {
                return elements.First();
            }
            else throw new Exception("The list is empty");
        }

        int firstNumber = ReturnFirstElement(numbers);
        Console.WriteLine("First number is: {0}", firstNumber);

        Rose blueRose = new Rose() { Price = 10, Name = "Blue Rose", Color = "blue" };
        Camomile swissCamomile = new Camomile() { Price = 10, Name = "Swiss Camomile", Color = "yellow-white" };
        int rosesAmount = 0;
        int camomilesAmount = 0;
        Console.WriteLine("Input roses amount:");
        bool success = int.TryParse(Console.ReadLine(), out rosesAmount);
        Console.WriteLine("Input camomiles amount:");
        bool success2 = int.TryParse(Console.ReadLine(), out camomilesAmount);

        static double ReturnPriceforBouquet<T>(T flower, int flowersAmount) where T : Flower
        {
            return flower.Price * flowersAmount;
        }

        double bouqetPrice = ReturnPriceforBouquet(blueRose, rosesAmount);
        double bouqetPrice2 = ReturnPriceforBouquet(swissCamomile, camomilesAmount);

        void PrintReceipt<T>(T flower, int amount) where T : Flower
        {
            double price = ReturnPriceforBouquet(flower, amount);
            Console.WriteLine("Color:{0}", flower.Color);
            Console.WriteLine("Price for 1 piece:{0}", flower.Price);
            Console.WriteLine($"This bouque of {flower.Name}s costs {price}");
        }

        PrintReceipt(swissCamomile, camomilesAmount);
        FlowerRepaint<Flower>.RepaintFlower(blueRose, "black");
        PrintReceipt(blueRose, rosesAmount);
        Car chevrolet = new Car("matiz",2009, 50);
        chevrolet.ReturnCarInfo();
        chevrolet.SetVinNumber();
        chevrolet.RepaintCar("grey");
        chevrolet.StopEngine();
    }
}


