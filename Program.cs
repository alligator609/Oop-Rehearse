var shapes = new List<Shape>();
shapes.Add(new Ractangular());
shapes.Add(new Circle());
shapes.Add(new Square());


var canvas = new Canvas();
canvas.DrawShape(shapes);


// var shape = new Shape();  // abstact class can't initiate
public class Canvas
{
    public void DrawShape(List<Shape> shapes)
    {
        foreach (Shape shape in shapes)
        {
            shape.Draw();
        }
    }
}



public class Ractangular : Shape
{
    public sealed override void Draw()
    {
        Console.WriteLine("draw ractangular");
    }
}
public class Circle : Shape
{
   // If applied to a method, prevents overriding of that method in a derived class. Slight faster but no use in real life 
    public sealed override void Draw()
    {
        Console.WriteLine("Circle ractangular");
    }
}
public class Square : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Square ractangular");
    }
}


// abstact use to tell that class has abstract  modifier 
public abstract class Shape
{
    public int Height { get; set; }
    public int Width { get; set; }

    public abstract void Draw(); // abstract  modifier states that a class or a member misses implementation , so its forces it
}
