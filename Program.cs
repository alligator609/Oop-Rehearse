

var test = new Text();
test.Width = 10;
test.Copy() ;
Console.WriteLine(test.Width);

public class Presentation
{
    public int Width { get; set; }
    public int Height { get; set; }

    public void Copy()
    {
        Console.WriteLine("Object copied");
    }
    public void Duplicate()
    {
        Console.WriteLine("Object duplicates");
    }
}

public class Text :Presentation
{
    public int FontSize { get; set; }
    public int FontName { get; set; }
    public void AddHyperLink (string url)
    {
        Console.WriteLine("We added a hyper link");
    }
}