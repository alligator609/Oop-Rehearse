

var cookier = new HttpCookie();

cookier["name"] = "Mosh";

Console.WriteLine(cookier["name"]);

public class HttpCookie 
{
    private readonly Dictionary<string, string> _dictionary;
    public DateTime Expiry { get; set; }
    public HttpCookie()
    {
        _dictionary = new Dictionary<string, string>();
    }

    // indexer 
    public string this[string key]
    {
        get { return _dictionary[key]; }
        set { _dictionary[key] = value; }
    }
}
