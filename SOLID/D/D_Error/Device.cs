namespace D_Error;

public interface IDevice
{
    void Activate();
}

public class Computer : IDevice
{
    public void Activate()
    {
        Console.WriteLine("Компьютер включен");
    }
}

public class Phone : IDevice
{
    public void Activate()
    {
        Console.WriteLine("Телефон включен");
    }
}
