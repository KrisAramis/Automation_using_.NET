namespace Kristina_Kulich__Application;

public class LoudGigantosarusDecorator:IGigantosaurus
{
    public IGigantosaurus _gigantosaurus;
//this is not the basic decorator but as decorator this class allows us to change the same examplar of claa Gigantosaur without 
//making many methods in basic class and we don't need to create new exemplars of the object if we need to adjust the examplar.
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