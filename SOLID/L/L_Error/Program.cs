using System;
using System.Collections.Generic;

public abstract class TouristDestination
{
    public string Name { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }

    public virtual string GetName() => Name;
    public virtual double GetLatitude() => Latitude;
    public virtual double GetLongitude() => Longitude;

    public virtual string GetGeologicalDescription()
    {
        return $"Геологическое описание места {Name}";
    }

    public virtual List<string> GetRecreationalActivities()
    {
        return new List<string> { "Фотосъемка", "Осмотр достопримечательностей" };
    }

    public virtual List<string> GetAccommodationOptions()
    {
        return new List<string> { "Отель", "Гостиница" };
    }
}

public class Mountain : TouristDestination
{
    public override string GetGeologicalDescription()
    {
        return $"Геологическое описание горы {Name}";
    }

    public override List<string> GetRecreationalActivities()
    {
        return new List<string> { "Альпинизм", "Лыжный спорт" };
    }

    public override List<string> GetAccommodationOptions()
    {
        return new List<string> { "Турбаза", "Кемпинг" };
    }
}

public class City : TouristDestination
{
    public override string GetGeologicalDescription()
    {
        throw new NotImplementedException("Города обычно не имеют геологического описания");
    }

    public override List<string> GetRecreationalActivities()
    {
        return new List<string> { "Осмотр достопримечательностей", "Посещение музеев" };
    }

    public override List<string> GetAccommodationOptions()
    {
        return new List<string> { "Отель", "Хостел" };
    }
}

public class TourOperator
{
    private List<TouristDestination> destinations;

    public TourOperator()
    {
        destinations = new List<TouristDestination>();
    }

    public void AddDestination(TouristDestination destination)
    {
        destinations.Add(destination);
    }

    public void PlanTour()
    {
        foreach (var destination in destinations)
        {
            Console.WriteLine($"Планирование тура в {destination.GetName()}");
            Console.WriteLine($"Геологическое описание: {destination.GetGeologicalDescription()}");
            Console.WriteLine($"Возможные виды отдыха: {string.Join(", ", destination.GetRecreationalActivities())}");
            Console.WriteLine($"Варианты размещения: {string.Join(", ", destination.GetAccommodationOptions())}");
            Console.WriteLine("---");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        var tourOperator = new TourOperator();

        tourOperator.AddDestination(new Mountain
        {
            Name = "Эверест",
            Latitude = 27.988056,
            Longitude = 86.925278
        });

        tourOperator.AddDestination(new City
        {
            Name = "Нью-Йорк",
            Latitude = 40.7128,
            Longitude = -74.0060
        });

        tourOperator.PlanTour();
    }
}