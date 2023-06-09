using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Kristina_Kulich__Application;

public class Cheque : IEquatable<Cheque>
{
    public string Productname { get; set; }
    /*private decimal _price;
    public string Price
    {
        get { return string.Format("{0:C}", _price); }
    }*/
    public double Quantity { get; set; }
    public decimal Price { get; set; }
    public decimal Sum { get; set; }


    /*public double Sum
    {
        get { return sum; }
        set { sum = this.CalculateSum(); }
    }*/
    public bool Equals(Cheque? other)
    {
        throw new NotImplementedException();
    }

    public decimal CalculateSum()
    {
        Sum = (decimal)Quantity* Price;
        return Sum;
    }

    public override string ToString()
    {
        return  Productname + "    $" + Price + "   Quantity:" + Quantity  ; // + " Sum: $ can't make sum be calculated up to here
    }
}

public class Homework_2
{
    public void Task_1()
    {
        Console.WriteLine("Input your favorite Book: "); //1-string
        string book = Console.ReadLine();
        Console.WriteLine(String.Format("{0} is your favorite book", book));
        
        Console.WriteLine("Input your average note:"); //2-double
        double note = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"You've got {note} for 9th grade");
        
        Console.WriteLine("Input Belarus population: "); //3- long
        long population = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine($"Belarus population is:{population:n0}"); 
        
        Console.WriteLine("Input your favorit symbol:"); //4-char
        char symbol = Convert.ToChar(Console.ReadLine());
        Console.WriteLine($"your favorite symbol category is: {symbol} {CharUnicodeInfo.GetUnicodeCategory(symbol)}");
        string c = String.Concat(symbol, population);
        Console.WriteLine(c);
    }

    public void Task_2()
    {
        Console.WriteLine("Input your heigh in meters:");
        decimal.TryParse(Console.ReadLine(), out decimal height);
        Console.WriteLine(String.Format("Your height is: {0}m", height));
        
        Console.WriteLine("Input your favorite number from 1-10:");
        short.TryParse(Console.ReadLine(), out short luckynumber);
        Console.WriteLine(String.Format("Your lucky number is: {0}", luckynumber));

    }

    public void Task_3()
    {
        int somevar = 0;
        bool result = int.TryParse(Console.ReadLine(), out somevar);
        Console.WriteLine($"You've inputted number: {somevar}");
    }

    public void Task_4()
    {
        int first = 55;
        Console.WriteLine(first);
        int second = first * 3;
        Console.WriteLine(second);
        int third = first + second;
        Console.WriteLine(third);
    }

    public void Task_5()
    {
        List<Cheque> auchan = new List<Cheque>();
        auchan.Add(new Cheque() { Productname = "Bananas", Price = 3, Quantity = 0.4 });
        auchan.Add(new Cheque() { Productname = "Caviar", Price = 15, Quantity = 0.15 });
        auchan.Add(new Cheque() { Productname = "Oatmeals", Price = 1, Quantity = 1 });
        auchan.Add(new Cheque() { Productname = "Peanutbutter", Price = 2, Quantity = 1 });
        auchan.Add(new Cheque() { Productname = "Honey", Price = 5, Quantity = 0.2 });
        auchan.Add(new Cheque() { Productname = "Moet", Price = 50, Quantity = 1 });
        decimal finalsum = 0;


        foreach (var product in auchan)
        {
            Console.WriteLine(product.ToString() + "  pay: " + String.Format("{0:C}", product.CalculateSum()));
            //double productsum = product.Price * product.Quantity;
            //Console.WriteLine(product.CalculateSum());
            finalsum += product.Sum;
        }

        double discount = 0.15;
        decimal finalsumdiscounted = finalsum - finalsum * (decimal)discount;
        int dayofweek = (int)DateTime.Today.DayOfWeek;
        if (dayofweek.Equals(4))
        {
            Console.WriteLine("applied 15% discount: " + String.Format("{0:C}", (decimal)discount*finalsum));
            Console.WriteLine("Final pay:" +String.Format( "{0:C}",finalsumdiscounted));
        }
    }

    public void Task_6()
    {
        double math1 = 5;
        double math2 = 10;
        math1/= math2;
        Console.WriteLine(math1);
        math2 +=math1;
        Console.WriteLine(math2);

        math2 *= math1;
        Console.WriteLine(math2); //5,25

        math1 =- math2;
        Console.WriteLine(math1);// -5,25
        double math3 = math1++ * math2 * 3;
        // 1) math1*math2 = -5,25*5,25 = -27,5625
        // math2*3 = -27,5625*3=-82.6875
        // 2) math1++= -5,25
        Console.WriteLine(math3);
        double math4 = math1 / 2 * --math2;
        //1) math1 = -4,25
        //2) math1/2 = -2,125
        //4)math2= 4,25
        //3)-2,125*4,25=-11,15625 -9,03125
        Console.WriteLine(math4);
    }

    public void Task_7()
    {
        bool a = 5 == 5;
        bool b = true && false == false;
        bool c= (5-4<1) || (5==5.0) != false;
        bool d = 4 != 3;
        bool e = 4 <= 4.5;
        Console.WriteLine($"{a}, {b}, {c}, {d}, {e}");
    }

    public void Task_8()
    {
        int i = 123;
        object o = i; //boxing
        i = 343;
        Console.WriteLine("Value-type = {0}", i);
        Console.WriteLine("object-type = {0}", o);

        int j = 10;
        object h = j;
        j = 100;
        int t = (int)h; //unboxing;
        Console.WriteLine("Value-type = {0}", j);
        Console.WriteLine("Object-type = {0}", h);
        Console.WriteLine("Value-type = {0}", t);
    }

    public void Task_9()
    {
        short a = 8;
        double b = 100;
        long c = 3;
        a = (short)b; //implicit
        b = a; //explicit ?? (неявное)a
    }

}






        
    
