namespace Kristina_Kulich__Application;

public class Gigantosaurus : IGigantosaurus
{
    public Gigantosaurus()
    {
        
    }
    
    //this is basic class which describes basic functionality
    public virtual void Roar()
    {
        string sound = "Dianosaurous roars";
        Console.WriteLine(sound);
    }
}