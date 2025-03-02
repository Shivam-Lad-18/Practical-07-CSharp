public interface IWorkable
{
    void Work();
}
public interface IEatable
{
    void Eat();
}
public interface ISleepable
{
    void Sleep();
}
public class FullTimeEmployee : IWorkable, IEatable, ISleepable
{
    public void Work()
    {
        Console.WriteLine("\tFull-time employee working.");
    }

    public void Eat()
    {
        Console.WriteLine("\tFull-time employee eating.");
    }

    public void Sleep()
    {
        Console.WriteLine("\tFull-time employee sleeping.");
    }
}
public class RobotWorker : IWorkable
{
    public void Work()
    {
        Console.WriteLine("\tRobot working.");
    }
}
