using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Kristina_Kulich__Application;

public class FlowerRepaint<T> where T:Flower
{
   // public T Color { get; set; }
    public static void RepaintFlower( T item, string newcolor, double upsell = 0.15) 
    {
        item.Color = newcolor;
        item.Price = item.Price*(1+upsell);
    }
}