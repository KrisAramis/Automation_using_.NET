// See https://aka.ms/new-console-template for more information

using System.Globalization;
using System.Runtime.InteropServices.JavaScript;
using Kristina_Kulich__Application;
using Kristina_Kulich__Application.Helpers;
using Kristina_Kulich__Application.CSharpLinq;

class Program
{
    static void Main(string[] args)
    {
        #region Task1

        int[] integers = new[] { 12, 8, 27, 78, 2, 3, 3, 4, 21, 1 };
        List<int> divedsby3 = integers.Select(i => i).Where(i => (i % 3 == 0)).ToList();
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
            where Helpers.CheckIfIsDevidedWithoutRamainder(b.Length, 2) ==
                  true // b.Length== Helpers.CheckIfIsDevidedWithoutRamainder(b.Length, 2)
            orderby b
            select b;
        foreach (var v in filteredbrands)
        {
            Console.WriteLine("Brands have even length: {0}", v);
        }

        #endregion

        #region Task4

        List<string> cities = new List<string>() { "Berlin", "London", "Paris", "Bobruisk", "Tokyo" };
        var citiesfiltered = cities.Select(i => i).Where(i => i.StartsWith("B") && i.EndsWith("k")).ToList();

        foreach (var g in citiesfiltered)
        {
            Console.WriteLine("City of dream is {0}", g);
        }

        #endregion

        #region Task5
        //couldn't solve, here my drafts

        //Console.WriteLine("input string with words in different case");
        //string allstring = Console.ReadLine();
        //allstring.Substring(0,Indexof(Indexof()))
        //   IsLower(allstring,)

        //       if()
        // List<string> allcases = new List<string>() { "BERLIN", "london", "paris", "BOBRUISK" ,"TOKYO" };

        #endregion

        #region Task6 
        //couldn't solve yet, here drafts
        int[] integers3 = new[] { 15, 4, -7, 15, -7, 14, 13, 4, 11, 15 };
        /*var onlydistinct = integers3.Where(i => i.Distinct().ToList();
        int[] reversedlist = onlydistinct.Reverse();
        integers2.Distinct();*/

        #endregion


        #region Task7

        bool checkIfTwo = IsTheNumberInMassive(2, integers);
        Console.WriteLine($"Is  in massive?: {checkIfTwo}");

        #endregion

        #region Task8

        /*List<string> twocolor = new List<string>();

        List<string> tricolor = new List<string>() { "#FFFFFF", "FF0000", "#FFFFFF" };*/
        //var selectedcolors = (tricolor.Count > 5).select(tricolor.First, tricolor.Last(a=> i)).ToList();

        /*var selectedcolors = from t in tricolor 
        where GetListAllElementsHeight(tricolor) > 5
        select (tricolor.SelectMany(tricolor.First(), tricolor.Last()));*/// not sure how to select 1st and 3rd elements

        //Console.WriteLine($"First and last colors are:{selectedcolors}");

        #endregion

        #region Task9

        IList<Student> studentList = new List<Student>()
        {
            new Student() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 1 },
            new Student() { StudentID = 2, StudentName = "Steve", Age = 21, StandardID = 1 },
            new Student() { StudentID = 3, StudentName = "Bill", Age = 18, StandardID = 2 },
            new Student() { StudentID = 4, StudentName = "Ram", Age = 20, StandardID = 2 },
            new Student() { StudentID = 5, StudentName = "Ron", Age = 21 }
        };

        var studentsNames = studentList.Select(s => s.StudentName).ToList();

        #endregion
    }

    public static int GetListAllElementsHeight(List<string> list)
    {
        int listlength = 0;
        for (int i = 0; i < list.Count - 1; i++)
        {
            listlength +=list[0].Length;
        }
        return listlength;
    }
    public static bool IsTheNumberInMassive(int numb, int[] integers)
    {
        int userinput = 0;
        int.TryParse(Console.ReadLine(),out userinput);
        bool isInArray = false;
        var arrayMatch = from n in integers
            where n == userinput
            select n;
        if (arrayMatch.Any())
        {
            isInArray = true;
        }
        else
        {
            isInArray = false;
        }

        return isInArray;
    }
}

     
    

