var shapes = new List<Shape>();
shapes.Add(new Ractangular());
shapes.Add(new Circle());
shapes.Add(new Square());


var canvas = new Canvas();
canvas.DrawShape(shapes);
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
    public override void Draw()
    {
        Console.WriteLine("draw ractangular");
    }
}
public class Circle : Shape
{
    public override void Draw()
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



public class Shape
{
    public int Height { get; set; }
    public int Width { get; set; }

    // virtual is used so that it can be override by child class
    public virtual void Draw()
    {

    }
}
