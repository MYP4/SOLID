using System.Reflection;

public interface IPort
{
    public void ArriveToPort();
}

public interface IWharehouse
{
    public void ArriveToWarehouse();
}

public interface IStation
{
    public void ArriveToStation();
}

public interface IAirport
{
    public void ArriveToAirport();
}

public abstract class Transport() { }

public class Ship : Transport, IPort
{
    public void ArriveToPort()
    {
        Console.WriteLine("Корабль прибыл в порт");
    }
}

public class Truck : Transport, IPort, IWharehouse, IAirport, IStation
{
    public void ArriveToAirport()
    {
        Console.WriteLine("Грузовик прибыл в аэропорт");
    }

    public void ArriveToWarehouse()
    {
        Console.WriteLine("Грузовик прибыл на склад");
    }

    public void ArriveToPort()
    {
        Console.WriteLine("Грузовик прибыл в порт");
    }

    public void ArriveToStation()
    {
        Console.WriteLine("Грузовик прибыл на ЖД станцию");
    }
}

public class Airplane : Transport, IAirport
{
    public void ArriveToAirport()
    {
        Console.WriteLine("Самолет прибыл в аэропорт");
    }
}

public class Train : Transport, IAirport, IPort, IWharehouse, IStation
{
    public void ArriveToAirport()
    {
        Console.WriteLine("Поезд прибыл в аэропорт");
    }

    public void ArriveToWarehouse()
    {
        Console.WriteLine("Поезд прибыл на склад");
    }

    public void ArriveToPort()
    {
        Console.WriteLine("Поезд прибыл в порт");
    }

    public void ArriveToStation()
    {
        Console.WriteLine("Поезд прибыл на ЖД станцию");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        var transports = new List<Transport>
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