// Interface ILogger to define a contract for logging
public interface ILogger
{
    void Log(string message);
}
// ConsoleLogger class implementing ILogger interface
public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine("\t"+message);
    }
}
// FileLogger class implementing ILogger interface
public class FileLogger : ILogger
{
    public void Log(string message)
    {
        // Simulate writing to a file (for example purposes)
        Console.WriteLine($"\tLog to file: {message}");
    }
}
// Application class to demonstrate Dependency Inversion Principle
public class Application
{
    // ILogger reference object to log messages
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
