using System;
using System.Numerics;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

namespace Kristina_Kulich__Application.CSharpBasics3;

public class Homework_3
{
  public void Task_1()
  {
    Console.WriteLine("Input number:");
    int number = 0;
    int.TryParse(Console.ReadLine(), out number);
   
    if (number % 2 == 0 && number % 5 == 0)
    {
      Console.WriteLine($"For number {number}: tutti-frutti");
    }
    else if (number % 2 == 0)
    {
      Console.WriteLine($"For number {number}: tutti");
    }
    else if (number % 5 == 0)
    {
      Console.WriteLine($"For number {number}: frutti");
    }

  }

  private void Checkbiggernumber(int number1, int number2)
  {
    int numberleast = Int32.Min(number1, number2);
    int numberbigger = Int32.Max(number1, number2);

    for (int i = numberleast; i <= numberbigger; i++)
    {
      if (i % 2 == 0 && i % 5 == 0)
      {
        Console.WriteLine($"For number {i}: tutti-frutti");
      }
      else if (i % 2 == 0)
      {
        Console.WriteLine($"For number {i}: tutti");
      }
      else if (i % 5 == 0)
      {
        Console.WriteLine($"For number {i}: frutti");
      }
      else
      {
        Console.WriteLine($"Number {i} is not a multiple of 2 and 5");
      }
    }
  }

  public void Task_2()
  {
    Console.WriteLine("Input a number that will be less that the next inputted number: ");
    int numberleast = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input bigger number: ");
    int numberbigger = Convert.ToInt32(Console.ReadLine());
    
    Checkbiggernumber(numberleast, numberbigger);
  }

  public void Task_3()
  {
    Console.WriteLine("Input some number: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input some number: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    
    Checkbiggernumber(number1, number2);
  }
}

  