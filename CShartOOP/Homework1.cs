using System.Globalization;

namespace Kristina_Kulich__Application.CShartOOP;

public class Homework1
{
        public void Calculatechecksum(int amount, double price, double sale)
        {
            double sum = amount * price - (sale*0.01);
            double sumDiscounted = sum - sum * 0.01;
            Console.WriteLine($"The final sum is:{sumDiscounted}");
        }

        public void Calculatechecksum(string[] product,int[] amount, double[] price, double[] sale)
        {
           // double sum = amount * price - (sale*0.01);
            //for (int j = product[0]; j < amount[].Length(); j++)
            {
                
            }
        }

        public void CalculateTrianglePerimeter( int[] sides)
        {
            int perimieter = 0;
            foreach (var side in sides)
            {
                //perimieter = sides[i];
                perimieter+=side;
            }
            Console.WriteLine($"Perimiter is: {perimieter} ");
        }

        public void Task_1()
        { 
            Console.WriteLine("Input product amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input product price");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input sale%, i.e. 5");
            double sale = Convert.ToDouble(Console.ReadLine());
            Calculatechecksum(amount, price,sale);
        }
        
        public void CalculateSquare(double radius)
        {
            double circlearea = Math.PI*radius*radius;
            Console.WriteLine($"The circle area is:{circlearea}");
        }

        public void CalculateSquare(double height, double side)
        {
            double trianglesquare = 0.5*height * side;
        }
        public void PrintCalculatedsum(int amount, double price, double sale)
        {
           // Calculatechecksum(amount, amount, price, price, price, sale);
           // Console.WriteLine($"{amount} apples cost {Calculatechecksum().}");
            //Calculatechecksum(int[]amount, dou)
        }
        public void Task_2()
        {
          //  Calculatechecksum();
            Console.WriteLine();
        }

        public void Task_3()
        {
            // Format a Color enumeration value in various ways.
            Console.WriteLine("OOP Principles in life");
            Console.WriteLine(
                "Incapsulation: I.e. you can't change car's property 'tank filed' unless you call method 'fill tank'\n" +
                "Abstraction: I.e. you operate your phone using 3 -5 actions with the finger and what's happening under the hood is hidden\n" +
                "Polimorfism: Surves to combine same charakteristics of objects to one class/interface. Like triangle/circle/square are figures\n" +
                "Inheritance: cat with little kittens");
        }
        
}