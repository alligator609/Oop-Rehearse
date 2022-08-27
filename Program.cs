

var car = new Car("123asdfasd");

public class Car : Vehicle
{
    public Car(string registrationNumber) : base(registrationNumber)
    {
        Console.WriteLine(" car registration no " + registrationNumber);

    }
}

public class Vehicle
{
    public Vehicle(string registrationNumber)
    {
        RegistrationNumber = registrationNumber;
        Console.WriteLine(" vehicle registration no "+ registrationNumber);
    }

    public string RegistrationNumber { get; }
}
