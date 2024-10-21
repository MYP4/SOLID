using S_Error;

/// <summary>
/// Кононов Игорь
/// 4 курс, 9 группа
/// F. Красота и спорт
/// Принцип 'S'
/// </summary>


class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        var athlete = new Athlete("Иван", 15, 50);

        athlete.PlayBasketball();
        athlete.PlayFootball();
    }
}