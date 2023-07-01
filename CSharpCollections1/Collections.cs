using System.Collections;
using System.Globalization;
using System.Runtime.InteropServices.JavaScript;

namespace Kristina_Kulich__Application.CSharpCollections1;

public class Collections
{
    private int l = 0;
    private int k = 0;
    public static int numberofeven;
    public static int numberofuneven;
    
    public int[] even = new int[numberofeven];
    public int[] uneven = new int[numberofuneven];
    
    public static void calculateMassiveLength(int[] massive)
    {
        for (int i=0; i < massive.Length; i++)
        {
            if (massive[i] % 2 == 0)
            {
                numberofeven++;
            }
            else
            {
                numberofuneven++;
            }
        }
    }

    public void DevideInEvenUnevenMassives(int[] massive)
    {
        
        for (int i = 0; i < massive.Length-1; i++)
        {
            if (massive[i] % 2 == 0)
            {
                even[l]=massive[i];
                l++;
            }
            else
            {
                uneven[k]=massive[i];
                k++;
            }
        }
    }
}