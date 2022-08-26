


var customer = new Customer(new DateTime(1993, 11, 7));


customer.Name = "test";
//customer.BirthDate = new DateTime(1993, 11, 7);

Console.WriteLine(customer.Age);

public class Customer 
{

    private string _name;

    public string Name { get; set; }  // c# automatically create private property called Name and get and set it 
    public DateTime BirthDate { get; private set; } // private used so that we will set it only once and its readonly 

    public Customer(DateTime birthDate)
    {
        BirthDate = birthDate;
    }

    public int Age
    {
        get
        {
            var timespan = DateTime.Now - BirthDate;
            var years = timespan.Days / 365;
            return years;
        }
    }
    /*    public string Name
        {
            get { return _name; }
            set { _name = value; }

        }*/
    /*    public string GetName ()
        {
            return _name; 
        }
        public void SetName(string name)
        {
            _name = name;
        }
    */

}
