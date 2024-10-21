using O_Correct;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        var kitchen = new Kitchen();

        var soup = new Soup();
        var mainCourse = new MainCourse();
        var dessert = new Dessert();

        kitchen.PrepareDish(soup);
        kitchen.PrepareDish(mainCourse);
        kitchen.PrepareDish(dessert);


        //var newDish = new NewDish();
        //kitchen.PrepareDish(newDish);
    }
}