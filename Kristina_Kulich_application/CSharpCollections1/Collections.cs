namespace Kristina_Kulich_application.Kristina_Kulich_application.CSharpCollections1;

using System.Collections;
using System.Globalization;
using System.Linq;

public class Collections
{
    private static int l = 0;
    private static int k = 0;
    public static int numberofeven;
    public static int numberofuneven;
    public static int internumberofeven = 0;
    public static int internumberofuneven = 0;

    public static void CalculateMassiveLength(int[] massive)
    {
        for (int i=0; i < massive.Length; i++)
        {

            if (massive[i] % 2 == 0)
            {
                internumberofeven++;
            }
            else
            {
                internumberofuneven++;
            }
        }
        numberofuneven = internumberofuneven;
        numberofeven = internumberofeven;
    }

    public static void DevideInEvenUnevenMassives(int[] massive)
    {
        int[] even = new int[numberofeven];
        int[] uneven = new int[numberofuneven];
        for (int i = 0; i < massive.Length; i++)
        {
            if (massive[i] % 2 == 0)
            {
                even[l]=massive[i];
                //Console.WriteLine("{0} even massive member",even[l]);
                l++;
            }
            else
            {
                uneven[k]=massive[i];
                //Console.WriteLine("{0} odd massive member",uneven[k]);
                k++;
            }
        }

        Array.Sort(even);
        Array.Sort(uneven);

        foreach (var k in even)
        {
            Console.WriteLine("{0} even massive member",k);
        }
        foreach (var k in uneven)
        {
            Console.WriteLine("{0} odd massive member",k);
        }
    }

    public static int FindDifferenceMaxMin(int[] massive)
    {
        Console.WriteLine("The difference is: {0}",massive.Max() - massive.Min());
        return massive.Max() - massive.Min();
    }

    public static void SortLastnames(List<string> lastnames)
    {
        var sortedlastnames = from l in lastnames
            orderby l
            select l;
        foreach (var l in sortedlastnames)
        {
            Console.WriteLine("Lastname: {0}", l);
        }
    }
}