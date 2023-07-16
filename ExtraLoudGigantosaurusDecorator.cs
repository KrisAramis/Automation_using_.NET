namespace Kristina_Kulich__Application;

public class ExtraLoudGigantosaurusDecorator:IGigantosaurus
{
    //this is decorator that's responsible for extra loud sounds without creating or modifying basic class Gigantosaurus
    protected IGigantosaurus _gigantosaurus;

    public ExtraLoudGigantosaurusDecorator (IGigantosaurus gigantosaurus)
    {
        _gigantosaurus = gigantosaurus;
    }

    public void Roar()
    {
        _gigantosaurus.Roar();
        Console.WriteLine("EXTRA LOOOOUd");
    }
}