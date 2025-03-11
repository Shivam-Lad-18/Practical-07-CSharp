// Different Interfaces for different type of action
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
// FullTimeEmployee class implementing all the interfaces
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
// RobotWorker class implementing only IWorkable interface
public class RobotWorker : IWorkable
{
    public void Work()
    {
        Console.WriteLine("\tRobot working.");
    }
}
