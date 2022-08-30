

var dv = new DbMigrator(new FileLogger("E:/RND/Oop-Rehearse/test.txt"));
var dv2 = new DbMigrator(new Logger());
dv.Migrate();
dv2.Migrate();

public class DbMigrator
{
    public ILogger _logger { get; set; }
    public DbMigrator(ILogger Logger)
    {
        _logger = Logger;
    }
    public void Migrate()
    {
        _logger.Info("Info" + DateTime.Now);

        _logger.Error("Error" + DateTime.Now);
    }
}
public interface ILogger
{
    void Info(string message);
    void Error(string message);
}

public class FileLogger : ILogger
{
    private readonly string _path;
    public FileLogger(string path)
    {
        _path = path;
    }
    public void Error(string message)
    {
        write(message);
    }

    public void Info(string message)
    {
        write(message);
    }

    public void write(string message)
    {

        using (var stream = new StreamWriter(_path, true))
        {
            stream.WriteLine(message);
        }
    }
}

public class Logger : ILogger
{
    public void Error(string message)
    {
        Console.WriteLine(message);
    }

    public void Info(string message)
    {
        Console.WriteLine(message);
    }

}