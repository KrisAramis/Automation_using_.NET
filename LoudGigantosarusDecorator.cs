namespace Kristina_Kulich__Application;

public class LoudGigantosarusDecorator:IGigantosaurus
{
    public IGigantosaurus _gigantosaurus;
//this is basic decorator 
    public LoudGigantosarusDecorator (IGigantosaurus gigantosaurus)
    {
        _gigantosaurus = gigantosaurus;
    }

    public void Roar()
    {
        _gigantosaurus.Roar();
        Console.WriteLine("\r very loud");
    }
}