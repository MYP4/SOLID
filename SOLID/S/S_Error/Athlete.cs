namespace S_Error;

public record Athlete(
    string FIO,
    int Age,
    double Weight)
{
    public void PlayFootball()
    {
        Console.WriteLine($"{FIO} играет в футбол за `ФК Спартак`");
    }

    public void PlayBasketball()
    {
        Console.WriteLine($"{FIO} играет в баскетбол за `БК Сахалин`");
    }
}
