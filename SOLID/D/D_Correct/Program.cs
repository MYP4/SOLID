
using D_Correct;

class Program
{
    static void Main(string[] args)
    {
        var computerStrategy = new ComputerStrategy();
        var technician = new Technician(computerStrategy);
        technician.FixDevice();


        var phoneStrategy = new PhoneStrategy();
        technician = new Technician(phoneStrategy);
        technician.FixDevice();
    }
}