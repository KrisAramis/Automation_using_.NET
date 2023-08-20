namespace Kristina_Kulich__Application.Helper;

public static class Helper
{
    private static int iseven;
    public static bool CheckIfIsDevidedWithoutRamainder(int number, int devider)
    {
        return number % devider == 0;
    }
}