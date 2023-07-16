namespace Kristina_Kulich__Application.CSharpOOP4;

public abstract class Shape
{
 private string _name;

 public string Name 
 { 
  get=> Name = _name;
  set { }
 }
 
 public Shape ()
 { }

 public Shape(string name)
 {
  _name = name;
 }

 public abstract double GetSquare();

 public virtual void ShapeInfo()
 {
  Console.WriteLine($"This is {_name}");
 }
}