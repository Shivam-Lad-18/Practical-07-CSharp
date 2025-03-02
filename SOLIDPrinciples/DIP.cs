public interface ILogger
{
    void Log(string message);
}
public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine("\t"+message);
    }
}
public class FileLogger : ILogger
{
    public void Log(string message)
    {
        // Simulate writing to a file (for example purposes)
        Console.WriteLine($"\tLog to file: {message}");
    }
}
public class Application
{
    private readonly ILogger logger;

    // Dependency injection via constructor
    public Application(ILogger logger)
    {
        this.logger = logger;
    }

    public void Run()
    {
        logger.Log("Application is running!");
    }
}
