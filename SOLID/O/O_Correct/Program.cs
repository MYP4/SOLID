public abstract class Dish
{
    public string Name { get; set; }
    public string[] Ingredients { get; set; }
    public string PreparationMethod { get; set; }

    public abstract void PrintRecipe();
    public abstract decimal CalculateCost();
}

public class Salad : Dish
{
    public override void PrintRecipe()
    {
        Console.WriteLine($"Рецепт салата: {Name}");
        Console.WriteLine($"Ингредиенты: {string.Join(", ", Ingredients)}");
        Console.WriteLine($"Приготовление: {PreparationMethod}");
    }

    public override decimal CalculateCost()
    {
        return 100 * Ingredients.Length;
    }
}

public class Soup : Dish
{
    public override void PrintRecipe()
    {
        Console.WriteLine($"Рецепт супа: {Name}");
        Console.WriteLine($"Ингредиенты: {string.Join(", ", Ingredients)}");
        Console.WriteLine($"Приготовление: {PreparationMethod}");
    }

    public override decimal CalculateCost()
    {
        return 150 * Ingredients.Length;
    }
}

public class MainCourse : Dish
{
    public override void PrintRecipe()
    {
        Console.WriteLine($"Рецепт основного блюда: {Name}");
        Console.WriteLine($"Ингредиенты: {string.Join(", ", Ingredients)}");
        Console.WriteLine($"Приготовление: {PreparationMethod}");
    }

    public override decimal CalculateCost()
    {
        return 200 * Ingredients.Length;
    }
}

public class Dessert : Dish
{
    public override void PrintRecipe()
    {
        Console.WriteLine($"Рецепт десерта: {Name}");
        Console.WriteLine($"Ингредиенты: {string.Join(", ", Ingredients)}");
        Console.WriteLine($"Приготовление: {PreparationMethod}");
    }

    public override decimal CalculateCost()
    {
        return 120 * Ingredients.Length;
    }
}

public class RecipeBook
{
    private List<Dish> dishes;

    public RecipeBook()
    {
        dishes = new List<Dish>();
    }

    public void AddDish(Dish dish)
    {
        dishes.Add(dish);
    }

    public void PrintRecipes()
    {
        foreach (var dish in dishes)
        {
            dish.PrintRecipe();
        }
    }

    public decimal CalculateTotalCost()
    {
        return dishes.Sum(d => d.CalculateCost());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        var recipeBook = new RecipeBook();

        recipeBook.AddDish(new Salad
        {
            Name = "Цезарь",
            Ingredients = ["Капуста", "Курица", "Сыр", "Хлеб"],
            PreparationMethod = "Нарежьте ингредиенты и заправьте соусом."
        });

        recipeBook.AddDish(new Soup
        {
            Name = "Борщ",
            Ingredients = ["Свекла", "Капуста", "Мясо", "Помидоры"],
            PreparationMethod = "Варите все ингредиенты в бульоне."
        });

        recipeBook.PrintRecipes();
        Console.WriteLine($"Общая стоимость всех блюд: {recipeBook.CalculateTotalCost()} руб.");
    }
}