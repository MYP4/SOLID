/// <summary>
/// Кононов Игорь
/// 4 курс, 9 группа
/// I. Техника (от карьерных самосвалов до стиральной машины)
/// Принцип 'D'
/// </summary>


public interface IHeavyEquipment
{
    void Work();
}

public class MiningTruck : IHeavyEquipment
{
    public void Work()
    {
        Console.WriteLine("Карьерный самосвал работает");
    }
}


public class WashingMachine : IHeavyEquipment
{
    public void Work()
    {
        Console.WriteLine("Стиральная машина работает");
    }
}

public class HeavyEquipmentOperator
{
    private readonly MiningTruck _miningTruck;
    private readonly WashingMachine _washingMachine;

    public HeavyEquipmentOperator(MiningTruck miningTruck, WashingMachine washingMachine)
    {
        _miningTruck = miningTruck;
        _washingMachine = washingMachine;
    }

    public void StartWork(string equipmentType)
    {
        switch (equipmentType.ToLower())
        {
            case "mining truck":
                _miningTruck.Work();
                break;
            case "washing machine":
                _washingMachine.Work();
                break;
            default:
                throw new ArgumentException("Неправильный тип оборудования");
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        var operator1 = new HeavyEquipmentOperator(new MiningTruck(), new WashingMachine());
        operator1.StartWork("mining truck");

        var operator2 = new HeavyEquipmentOperator(new MiningTruck(), new WashingMachine());
        operator2.StartWork("washing machine");
    }
}