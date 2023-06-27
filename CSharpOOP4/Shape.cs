namespace Kristina_Kulich__Application.CSharpOOP4;

public abstract class Shape
{
 private string _name;

 public Shape ()
 { }

 public Shape(string name)
 {
  _name = name;
 }

 public abstract double GetSquare();

 public abstract void ShapeInfo();
}