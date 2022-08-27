

var db = new DbMigrator(new Logger());

var logger = new Logger();

var intaller = new Installer (logger);

db.Migrate();
intaller.Install();

public class DbMigrator
{
    private readonly Logger _logger;

    public DbMigrator(Logger logger)
    {
        _logger = logger;
    }
    public void Migrate()
    {
        _logger.Log("we are migrating");
    }
}

public class Installer
{
    private readonly Logger _logger;

    public Installer(Logger logger)
    {
        _logger = logger;
    }
    public void Install()
    {
        _logger.Log("we are Installing");
    }
}


public class Logger
{

    public void Log(string msg)
    {
        Console.WriteLine(msg);
    }
}
