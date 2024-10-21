namespace D_Correct;

public enum DeviceType
{
    Phone,
    Computer
}

public class Technician
{
    private readonly IDeviceStrategy _strategy;

    public Technician(IDeviceStrategy strategy)
    {
        _strategy = strategy;
    }

    public void FixDevice()
    {
        var device = _strategy.CreateDevice();
        device.Activate();
    }
}

public class ComputerStrategy : IDeviceStrategy
{
    public IDevice CreateDevice() => new Computer();
}

public class PhoneStrategy : IDeviceStrategy
{
    public IDevice CreateDevice() => new Phone();
}