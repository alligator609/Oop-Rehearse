

using Oop_Rehearse;

static void usePoints()
{

    try
    {
        var point = new Point(10, 20);

        point.Move(40, 60);
        Console.WriteLine("point is at " + point.X + point.Y);

        point.Move(null);
        Console.WriteLine("point is at " + point.X + point.Y);
    }
    catch (Exception)
    {

        Console.WriteLine("An unspected error accure ");

    }

}


Console.WriteLine(Calculator.Add(1,2,3,4,5,6,7,8));



public class Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }
    public void Move (int x , int y)
    {
        this.X = x;
        this.Y = y;

    }

    public void Move(Point newlocation)
    {
        /*  this.X = newlocation.X;
          this.Y = newlocation.Y;*/
        if (newlocation == null) 
            throw new ArgumentNullException ("null new location");
        Move(newlocation.X, newlocation.Y);

    }

}

