namespace Kristina_Kulich__Application;

public abstract class LoudGigantosarusDecorator:IGigantosaurus
{
    protected IGigantosaurus _gigantosaurus;
//this is basic decorator 
    public LoudGigantosarusDecorator (IGigantosaurus gigantosaurus)
    {
        _gigantosaurus = gigantosaurus;
    }

    public virtual void Roar()
    {
        _gigantosaurus.Roar();
    }
}