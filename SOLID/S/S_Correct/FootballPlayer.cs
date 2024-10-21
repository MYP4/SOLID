namespace S_Correct;

public class FootballPlayer
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }
    public SportType Type { get; }
    public SportClub Club { get; set; }

    public FootballPlayer(string name, int age, double weight, SportClub club)
    {
        Name = name;
        Age = age;
        Weight = weight;
        Type = SportType.Basketball;
        Club = club;
    }

    public void Play()
    {
        Console.WriteLine($"{Name} играет в {Type} за `{Club}`");
    }
}
