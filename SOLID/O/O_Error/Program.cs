/// <summary>
/// Кононов Игорь
/// 4 курс, 9 группа
/// G. Кулинария и покупки
/// Принцип 'S'
/// </summary>

public enum DishType
{
    Salad,
    Soup,
    MainCourse,
    Dessert
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
            switch (dish.Type)
            {
                case DishType.Salad:
                    Console.WriteLine($"Рецепт салата: {dish.Name}");
                    Console.WriteLine($"Ингредиенты: {string.Join(", ", dish.Ingredients)}");
                    Console.WriteLine($"Приготовление: {dish.PreparationMethod}");
                    break;
                case DishType.Soup:
                    Console.WriteLine($"Рецепт супа: {dish.Name}");
                    Console.WriteLine($"Ингредиенты: {string.Join(", ", dish.Ingredients)}");
                    Console.WriteLine($"Приготовление: {dish.PreparationMethod}");
                    break;
                case DishType.MainCourse:
                    Console.WriteLine($"Рецепт основного блюда: {dish.Name}");
                    Console.WriteLine($"Ингредиенты: {string.Join(", ", dish.Ingredients)}");
                    Console.WriteLine($"Приготовление: {dish.PreparationMethod}");
                    break;
                case DishType.Dessert:
                    Console.WriteLine($"Рецепт десерта: {dish.Name}");
                    Console.WriteLine($"Ингредиенты: {string.Join(", ", dish.Ingredients)}");
                    Console.WriteLine($"Приготовление: {dish.PreparationMethod}");
                    break;
                default:
                    throw new ArgumentException("Неизвестный тип блюда", nameof(dish.Type));
            }
        }
    }

    public void CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (var dish in dishes)
        {
            switch (dish.Type)
            {
                case DishType.Salad:
                    totalCost += CalculateSaladCost(dish);
                    break;
                case DishType.Soup:
                    totalCost += CalculateSoupCost(dish);
                    break;
                case DishType.MainCourse:
                    totalCost += CalculateMainCourseCost(dish);
                    break;
                case DishType.Dessert:
                    totalCost += CalculateDessertCost(dish);
                    break;
            }
        }
        Console.WriteLine($"Общая стоимость всех блюд: {totalCost} руб.");
    }

    private decimal CalculateSaladCost(Dish dish)
    {
        return 100 * dish.Ingredients.Length;
    }

    private decimal CalculateSoupCost(Dish dish)
    {
        return 150 * dish.Ingredients.Length;
    }

    private decimal CalculateMainCourseCost(Dish dish)
    {
        return 200 * dish.Ingredients.Length;
    }

    private decimal CalculateDessertCost(Dish dish)
    {
        return 120 * dish.Ingredients.Length;
    }
}

public class Dish
{
    public string Name { get; set; }
    public DishType Type { get; set; }
    public string[] Ingredients { get; set; }
    public string PreparationMethod { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        var recipeBook = new RecipeBook();

        recipeBook.AddDish(new Dish
        {
            Name = "Цезарь",
            Type = DishType.Salad,
            Ingredients = new[] { "Капуста", "Курица", "Сыр", "Хлеб" },
            PreparationMethod = "Нарежьте ингредиенты и заправьте соусом."
        });

        recipeBook.AddDish(new Dish
        {
            Name = "Борщ",
            Type = DishType.Soup,
            Ingredients = new[] { "Свекла", "Капуста", "Мясо", "Помидоры" },
            PreparationMethod = "Варите все ингредиенты в бульоне."
        });

        recipeBook.PrintRecipes();
        recipeBook.CalculateTotalCost();
    }
}