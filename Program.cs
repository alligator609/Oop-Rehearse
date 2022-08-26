


var customer = new Customer(1);

customer.Orders.Add(new Order());
customer.Orders.Add(new Order());
customer.Orders.Add(new Order());
customer.Orders.Add(new Order());


customer.Promote();


Console.WriteLine(customer.Orders.Count);

public class Customer 
{
    public int Id;
    public string Name;
    public readonly List<Order> Orders = new List<Order>();

    public Customer (int id)
    {
        Id = id;
    }


    public Customer(int id, string name) : this(id)
    {
        Id = id;
        Name = name;
    }

    public void Promote()
    {
        // if u accedently reinitilize // so that readonly filed will give u an error cause it will initilize only once 
       // Orders = new List<Order>();
    }
}


public class Order
{ 
}