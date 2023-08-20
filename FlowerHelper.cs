namespace Kristina_Kulich__Application;

public class FlowerHelper
{
    public static T ReturnFirstElement<T>(List<T> elements)
    {
        if (elements.Count > 0)
        {
            return elements.First();
        }
        else throw new Exception("The list is empty");
    }
    
    public static double ReturnPriceforBouquet<T>(T flower, int flowersAmount) where T : Flower
    {
        return flower.Price * flowersAmount;
    }
    
    public static void PrintReceipt<T>(T flower, int amount) where T : Flower
    {
        double price = ReturnPriceforBouquet(flower, amount);
        Console.WriteLine("Color:{0}", flower.Color);
        Console.WriteLine("Price for 1 piece:{0}", flower.Price);
        Console.WriteLine($"This bouque of {flower.Name}s costs {price}");
    }
}