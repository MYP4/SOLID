namespace D_Correct;

public class Phone : IDevice
{
    public string DeviceName => "Телефон";

    public void Activate()
    {
        Console.WriteLine($"Активация {DeviceName}");
    }
}
