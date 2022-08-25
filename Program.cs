


using Oop_Rehearse;

var customer = new Customer(1,"Jhon");

Console.WriteLine(customer.Id);
Console.WriteLine(customer.Name);

customer.Orders.Add(new Order());

// this is another way to initilize a object so that we don't have to use costructor 
var oi = new ObejctInit
{
    Id = 1,
    Name = "name",
};

Console.WriteLine(oi.Id);



public class ObejctInit
{
    public int Id { get; set; }
    public string Name { get; set; }

}