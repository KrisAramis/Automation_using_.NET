// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;
using Kristina_Kulich__Application;
using Kristina_Kulich__Application.CShartOOP;

class Program
{
    static void Main(string[] args)
    {
     /*
     new Homework_1().Task_1();   
     new Homework_1().Task_2();
     new Homework_1().Task_3();
     new Homework_1().Task_4();
     new Homework_1().Task_5();
     new Homework_1().Task_6();
     */

     #region 1
     Console.WriteLine("Input product amount");
     int amount = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Input product price");
     double price = Convert.ToDouble(Console.ReadLine());
     Console.WriteLine("Input sale%, i.e. 5");
     double sale = Convert.ToDouble(Console.ReadLine());
     //new Homework1().Calculatechecksum(amount, price, sale);

     #endregion

     //new Homework1().Task_1();

     #region 4
     
     Console.WriteLine("Input sides of triangle:");
     int[] sides;
     sides = new int[4];
     for (int i =0; i<sides.Length;)
     {
         Console.WriteLine("Input side");
         sides[i] = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Element in index " + i + ": " + sides[i]+ "length"+ sides.Length);
         i++;
     }
     new Homework1().CalculateTrianglePerimeter(sides);
     #endregion

     #region 5
     new Homework1().CalculateSquare(10);
     new Homework1().CalculateSquare(8,10);

     #endregion
    }
}
