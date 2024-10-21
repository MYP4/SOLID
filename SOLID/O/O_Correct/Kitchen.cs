namespace O_Correct;

public abstract class Dish
{
    public abstract void Prepare();
}

public class Soup : Dish
{
    public override void Prepare()
    {
        Console.WriteLine("Готовит суп");
    }
}

public class MainCourse : Dish
{
    public override void Prepare()
    {
        Console.WriteLine("Готовит главное блюдо");
    }
}

public class Dessert : Dish
{
    public override void Prepare()
    {
        Console.WriteLine("Готовит десерт");
    }
}

public class Kitchen
{
    public void PrepareDish(Dish dish)
    {
        dish.Prepare();
    }
}
