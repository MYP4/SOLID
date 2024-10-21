using System.Reflection;

public interface ITransport{ }

public interface IPort : ITransport
{
    public void ArriveToPort();
}

public interface IWharehouse : ITransport
{
    public void ArriveToWarehouse();
}

public interface IStation : ITransport
{
    public void ArriveToStation();
}

public interface IAirport : ITransport
{
    public void ArriveToAirport();
}

public class Ship : IPort
{
    public void ArriveToPort() =>Console.WriteLine("Корабль прибыл в порт");
}

public class Truck : IPort, IWharehouse, IAirport, IStation
{
    public void ArriveToAirport() => Console.WriteLine("Грузовик прибыл в аэропорт");

    public void ArriveToWarehouse() => Console.WriteLine("Грузовик прибыл на склад");

    public void ArriveToPort() => Console.WriteLine("Грузовик прибыл в порт");

    public void ArriveToStation() => Console.WriteLine("Грузовик прибыл на ЖД станцию");
}

public class Airplane : IAirport
{
    public void ArriveToAirport() => Console.WriteLine("Самолет прибыл в аэропорт");
}

public class Train : IAirport, IPort, IWharehouse, IStation
{
    public void ArriveToAirport() => Console.WriteLine("Поезд прибыл в аэропорт");

    public void ArriveToWarehouse() => Console.WriteLine("Поезд прибыл на склад");

    public void ArriveToPort() => Console.WriteLine("Поезд прибыл в порт");

    public void ArriveToStation() => Console.WriteLine("Поезд прибыл на ЖД станцию");
}


class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        var transports = new List<ITransport>
        {
            new Ship(),
            new Truck(),
            new Airplane(),
            new Train()
        };

        foreach (var transport in transports)
        {
            var type = transport.GetType();
            var methods = type.GetMethods();

            Console.WriteLine("==================================================================");
            Console.WriteLine(type);
            Console.WriteLine("==================================================================");

            foreach (var method in methods)
            {
                try
                {
                    var classMethod = type.GetMethod(method.Name, BindingFlags.Public | BindingFlags.Instance);

                    if (classMethod != null)
                    {
                        classMethod.Invoke(transport, null);
                        Console.WriteLine($"Вызванный метод интерфейса: {method.Name}");
                        Console.WriteLine("------------------------------------------------------------------");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при вызове метода {method.Name}: {ex.Message}");
                }
            }
        }
    }
}