public class BeautyService
{
    public void Execute(string clientName)
    {
        Console.WriteLine($"Предоставляем услуги красоты для {clientName}");
        Console.WriteLine("Мы делаем маникюр");
        Console.WriteLine("Мы делаем педикюр");
        Console.WriteLine("Мы делаем массаж");
        Console.WriteLine("--------------------------------------------------------");
    }
}


public class SportsService
{
    public void Execute(string clientName)
    {
        Console.WriteLine($"Предоставляем спортивные услуги для {clientName}");
        Console.WriteLine("Мы организуем тренировки по бегу");
        Console.WriteLine("Мы организуем тренировки по плаванию");
        Console.WriteLine("Мы организуем тренировки по йоге");
        Console.WriteLine("--------------------------------------------------------");
    }
}


public class FinancialManager
{
    public void ManageFinances()
    {
        Console.WriteLine("Управляем финансами центра красоты и спорта");
        Console.WriteLine("Считаем доходы от услуг красоты");
        Console.WriteLine("Считаем доходы от спортивных услуг");
        Console.WriteLine("Оплачиваем сотрудникам зарплату");
        Console.WriteLine("--------------------------------------------------------");
    }
}


public class EquipmentMaintenance
{
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

        var beautyService = new BeautyService();
        var sportsService = new SportsService();

        beautyService.Execute("Анна");
        sportsService.Execute("Иван");

        var financialManager = new FinancialManager();
        financialManager.ManageFinances();

        var equipmentMaintenance = new EquipmentMaintenance();
        equipmentMaintenance.MaintainEquipment();
    }
}
