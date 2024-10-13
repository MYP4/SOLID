using System.Reflection;

/// <summary>
/// Кононов Игорь
/// 4 курс, 9 группа
/// A. Грузоперевозки и логистика (грузы, порты, склады, города, поезда, контейнеры...)
/// Принцип 'I'
/// </summary>


public interface Transport
{
    public void ArriveToPort();
    public void ArriveToWarehouse();
    public void ArriveToStation();
    public void ArriveToAirport();
}

public class Ship : Transport
{
    public void ArriveToAirport()
    {
        Console.WriteLine("Корабль не может прибыть в аэропорт");
    }

    public void ArriveToWarehouse()
    {
        Console.WriteLine("Корабль не может прибыть на склад");
    }

    public void ArriveToPort()
    {
        Console.WriteLine("Корабль прибыл в порт");
    }

    public void ArriveToStation()
    {
        Console.WriteLine("Корабль не может прибыть на ЖД станцию");
    }
}

public class Truck : Transport
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

public class Airplane : Transport
{
    public void ArriveToAirport()
    {
        Console.WriteLine("Самолет прибыл в аэропорт");
    }

    public void ArriveToWarehouse()
    {
        Console.WriteLine("Самолет не может прибыть на склад");
    }

    public void ArriveToPort()
    {
        Console.WriteLine("Самолет не может прибыть в порт");
    }

    public void ArriveToStation()
    {
        Console.WriteLine("Самолет не может прибыть на ЖД станцию");
    }
}

public class Train : Transport
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