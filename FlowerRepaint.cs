using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Kristina_Kulich__Application;

public class FlowerRepaint<T> 
{
    public static void RepaintFlower(Flower flower, string newcolor, double upsell = 0.15)
    {
        flower.Color = newcolor;
        flower.Color = newcolor;
        flower.Price = flower.Price*(1+upsell);
    }
}