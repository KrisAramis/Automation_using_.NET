namespace Kristina_Kulich__Application;

public class ExtraLoudGigantosaurusDecorator:LoudGigantosarusDecorator
{
    //this is decorator that's responsible for extra loud sounds without creating or modifying basic class Gigantosaurus
    public ExtraLoudGigantosaurusDecorator( IGigantosaurus gigantosaurus):base(gigantosaurus){}
   
    public override void Roar()
    {
        base.Roar();
        Console.WriteLine("It's really louddd");
    }
}