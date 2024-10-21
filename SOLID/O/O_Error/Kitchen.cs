namespace O_Error;

public enum DishType
{
    Soup,
    MainCourse,
    Dessert
}

public class Kitchen
{
    public void PrepareDish(DishType type)
    {
        switch (type)
        {
            case DishType.Soup:
                Console.WriteLine("Готовит суп");
                break;
            case DishType.MainCourse:
                Console.WriteLine("Готовит главное блюдо");
                break;
            case DishType.Dessert:
                Console.WriteLine("Готовит десерт");
                break;
            default:
                throw new ArgumentException("Неизвестный тип блюда");
        }
    }
}