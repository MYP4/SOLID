/// <summary>
/// Кононов Игорь
/// 4 курс, 9 группа
/// F. Красота и спорт
/// Принцип 'S'
/// </summary>


public class BeautyAndSportsCenter
{
    public void ProvideBeautyServices(string clientName)
    {
        Console.WriteLine($"Предоставляем услуги красоты для {clientName}");
        Console.WriteLine("Мы делаем маникюр");
        Console.WriteLine("Мы делаем педикюр");
        Console.WriteLine("Мы делаем массаж");
        Console.WriteLine("--------------------------------------------------------");
    }

    public void ProvideSportsServices(string clientName)
    {
        Console.WriteLine($"Предоставляем спортивные услуги для {clientName}");
        Console.WriteLine("Мы организуем тренировки по бегу");
        Console.WriteLine("Мы организуем тренировки по плаванию");
        Console.WriteLine("Мы организуем тренировки по йоге");
        Console.WriteLine("--------------------------------------------------------");
    }

    public void ManageFinances()
    {
        Console.WriteLine("Управляем финансами центра красоты и спорта");
        Console.WriteLine("Считаем доходы от услуг красоты");
        Console.WriteLine("Считаем доходы от спортивных услуг");
        Console.WriteLine("Оплачиваем сотрудникам зарплату");
        Console.WriteLine("--------------------------------------------------------");
    }

    public void MaintainEquipment()
    {
        Console.WriteLine("Осуществляем техническое обслуживание оборудования");
        Console.WriteLine("Чистим косметологические аппараты");
        Console.WriteLine("Ремонтируем тренажеры");
        Console.WriteLine("Проверяем санитарное состояние помещений");
        Console.WriteLine("--------------------------------------------------------");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        var center = new BeautyAndSportsCenter();

        center.ProvideBeautyServices("Анна");
        center.ProvideSportsServices("Иван");
        center.ManageFinances();
        center.MaintainEquipment();
    }
}