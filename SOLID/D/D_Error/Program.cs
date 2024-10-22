using D_Error;

/// <summary>
/// Кононов Игорь
/// 4 курс, 9 группа
/// I. Техника (от карьерных самосвалов до стиральной машины)
/// Принцип 'D'
/// </summary>


class Program
{
    static void Main(string[] args)
    {
        var computer = new Computer();
        var phone = new Phone();

        var technician = new Technician(computer, phone);

        technician.FixDevice(DeviceType.Computer);
        technician.FixDevice(DeviceType.Phone);
    }

}