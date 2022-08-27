
// up cast 
Text text = new Text ();

Shape shape = text;

text.Width  = 1;   // text have al the parameter from shapre class
shape.Width = 2;  // shape only have the parameter of its own

Console.WriteLine(text.Width);

// down cast


Shape shape1 = new Text();
Text text1 = (Text)shape;  // also can written Text text1 = shape as Text; 

text1.FontName = "test"; // as u can see text1 can use all the parameter of shape and text 

Console.WriteLine(text1.FontName);



public class Text : Shape
{
    public int FontSize { get; set; }

    public string FontName { get; set; }

}

public class Shape
{
    public int Width { get; set; }
    public int Height { get; set; }
    public int X { get; set; }
    public int Y { get; set; }

    public void Draw()
    {

    }
    
}
