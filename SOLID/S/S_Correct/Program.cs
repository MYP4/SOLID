using S_Correct;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        var footballPlayer = new FootballPlayer("Иван", 22, 75, SportClub.Spartak);
        var basketBallPlayer = new BasketBallPlayer("Роман", 35, 80, SportClub.Zenit);

        footballPlayer.Play();
        basketBallPlayer.Play();
    }
}
