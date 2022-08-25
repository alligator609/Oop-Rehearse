
var person = new Person();
person.Name = "john";
 person.Introduce("introduce");

var p = person.Parse1("using paerse 1");

var p2 = Person.Parse2("using paerse 2");

p.Introduce("introduce");
p2.Introduce("introduce");

// accessModifier type Iterntifier 
public class Person
{

    // accessModifier type Iterntifier 
    public string Name { get; set; }

    public void Introduce (string to )
    {
        Console.WriteLine("Hi " + to + ", I am " +Name);
    }

    // static is used so that we don't have to create new instance to access the object .
    // below method returns an object of Person. Static method is olny accesealbe to class not object 
    public Person Parse1 (string str)
    {
        var person = new Person();
        person.Name = str;
        return person;
    }

    public static Person Parse2(string str)
    {
        var person = new Person();
        person.Name = str;
        return person;
    }
}



