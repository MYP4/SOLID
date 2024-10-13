public interface IHeavyEquipment
{
    string Name { get; }
    void Work();
}


public class MiningTruck : IHeavyEquipment
{
    public string Name => "Карьерный самосвал";

    public void Work()
    {
        Console.WriteLine($"{Name} загружается");
    }
}


public class WashingMachine : IHeavyEquipment
{
    public string Name => "Стиральная машина";

    public void Work()
    {
        Console.WriteLine($"{Name} моет белье");
    }
}


public class HeavyEquipmentOperator
{
    private readonly IHeavyEquipment _equipment;

    public HeavyEquipmentOperator(IHeavyEquipment equipment)
    {
        _equipment = equipment;
    }

    public void StartWork()
    {
        Console.WriteLine($"Начало работы: {_equipment.Name}");
        _equipment.Work();
    }
}


public class EquipmentManager
{
    private readonly IHeavyEquipment _miningTruck;
    private readonly IHeavyEquipment _washingMachine;

    public EquipmentManager(IHeavyEquipment miningTruck, IHeavyEquipment washingMachine)
    {
        _miningTruck = miningTruck;
        _washingMachine = washingMachine;
    }

    public void SwitchTo(string equipmentType)
    {
        switch (equipmentType.ToLower())
        {
            case "mining truck":
                Console.WriteLine("Переключение на карьерный самосвал");
                _miningTruck.Work();
                break;
            case "washing machine":
                Console.WriteLine("Переключение на стиральную машину");
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

        var miningTruck = new MiningTruck();
        var washingMachine = new WashingMachine();


        var operator1 = new HeavyEquipmentOperator(miningTruck);
        operator1.StartWork();

        var manager = new EquipmentManager(miningTruck, washingMachine);
        manager.SwitchTo("mining truck");

        manager.SwitchTo("washing machine");
    }
}