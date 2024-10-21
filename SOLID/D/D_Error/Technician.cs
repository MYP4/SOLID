namespace D_Error;

public enum DeviceType
{
    Phone,
    Computer
}

public class Technician
{
    private Computer _computer;
    private Phone _phone;

    public Technician(Computer computer, Phone phone)
    {
        _computer = computer;
        _phone = phone;
    }

    public void FixDevice(DeviceType deviceType)
    {
        switch (deviceType)
        {
            case DeviceType.Computer:
                _computer.Activate();
                break;
            case DeviceType.Phone:
                _phone.Activate();
                break;
            default:
                Console.WriteLine("Неверный тип устройства");
                break;
        }
    }
}

