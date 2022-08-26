


var customer = new Customer();


customer.SetName("zia");

Console.WriteLine(customer.GetName());

public class Customer 
{
    private string _name;

    public string GetName ()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }


}
