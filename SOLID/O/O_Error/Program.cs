using O_Error;

/// <summary>
/// Кононов Игорь
/// 4 курс, 9 группа
/// G. Кулинария и покупки
/// Принцип 'S'
/// </summary>


class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        var kitchen = new Kitchen();

        kitchen.PrepareDish(DishType.Soup);
        kitchen.PrepareDish(DishType.MainCourse);
        kitchen.PrepareDish(DishType.Dessert);
    }
}