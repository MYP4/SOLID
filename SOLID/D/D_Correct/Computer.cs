namespace D_Correct;

public class Computer : IDevice
{
    public string DeviceName => "Компьютер";

    public void Activate()
    {
        Console.WriteLine($"Активация {DeviceName}");
    }
}
