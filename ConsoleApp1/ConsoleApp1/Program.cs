using Sweets_class;

namespace Sweets_class;

interface IPrint
{
    void Print();
}
public class Sweets
{
    private string _name;
    private int _price;
    private double _weight;
    public string Name
    {
        get { return _name; }

        set { _name = value; }
    }
    public int Price
    {
        get { return _price; }

        set { _price = value; }
    }
    public double Weight
    {
        get { return _weight; }

        set { _weight = value; }
    }
}

public class Chocolate : Sweets, IPrint
{
    private bool _nuts;
    private double _bitterness;

    public double Bitterness
    {
        get { return _bitterness; }

        set { _bitterness = value; }
    }

    public bool Nuts
    {
        get { return _nuts; }

        set { _nuts = value; }
    }
    public void Print()
    {
        Console.WriteLine($"Название: {Name}");
        Console.WriteLine($"Цена: {Price} рублей");
        Console.WriteLine($"Вес: {Weight} грамм");
        if (_nuts)
        {
            Console.WriteLine($"Орехи в шоколаде: есть");
        }
        else
        {
            Console.WriteLine($"Орехи в шоколаде: нет");
        }
        Console.WriteLine($"Горькость шоколада: {Nuts} %");
    }
}
public class Marmalade : Sweets, IPrint
{
    private bool _sprinkling;
    private string _form;
    public bool Sprinkling
    {
        get { return _sprinkling; }

        set { _sprinkling = value; }
    }
    public string Form
    {
        get { return _form; }

        set { _form = value; }
    }
    public void Print()
    {
        Console.WriteLine($"Название: {Name}");
        Console.WriteLine($"Цена: {Price} рублей");
        Console.WriteLine($"Вес: {Weight} грамм");
        if (_sprinkling)
        {
            Console.WriteLine($"Посыпка: есть");
        }
        else
        {
            Console.WriteLine($"Посыпка: нет");
        }
        Console.WriteLine($"Вид мармелада: {Form}");
    }
}

public class Caramel : Sweets, IPrint
{
    private double _sugar;
    public double Sugar
    {
        get { return _sugar; }

        set { _sugar = value; }
    }
    public void Print()
    {
        Console.WriteLine($"Название: {Name}");
        Console.WriteLine($"Цена: {Price} рублей");
        Console.WriteLine($"Вес: {Weight} грамм");
        Console.WriteLine($"Содержание сахара: {Sugar}%");
    }
}

public class Lollypop : Caramel, IPrint
{
    private string _flavor;
    private bool _stick;
    public string Flavor
    {
        get { return _flavor; }

        set { _flavor = value; }
    }
    public bool Stick
    {
        get { return _stick; }

        set { _stick = value; }
    }
    void IPrint.Print()
    {
        Console.WriteLine($"Название: {Name}");
        Console.WriteLine($"Цена: {Price} рублей");
        Console.WriteLine($"Вес: {Weight} грамм");
        if (_stick)
        {
            Console.WriteLine($"Палочка у леденца: есть");
        }
        else
        {
            Console.WriteLine($"Палочка у леденца: нет");
        }
        Console.WriteLine($"Вкус леденца: {Flavor}");
    }
}

public class Filled : Caramel, IPrint
{
    private double _humidity;
    public double Humidity
    {
        get { return _humidity; }

        set { _humidity = value; }
    }
    public void Print()
    {
        Console.WriteLine($"Название: {Name}");
        Console.WriteLine($"Цена: {Price} рублей");
        Console.WriteLine($"Вес: {Weight} грамм");
        Console.WriteLine($"Влажность начинки: {Humidity}");
    }
}

class Gift
{
    public List<Sweets> ListOfSweets = new List<Sweets>();
    public void WeightCount()
    {
        double totalWeight = 0;
        foreach (Sweets p in ListOfSweets)
        {
            totalWeight += p.Weight;
        }
        Console.WriteLine($"Вес: {totalWeight} грамм");
    }
    public void ShowInfo(IPrint p)
    {
        p.Print();
    }
}

class Program
{
    static void Main(string[] args)
    {
        var p1 = new Lollypop();
        p1.Name = "Чупа-Чупс";
        p1.Price = 25;
        p1.Weight = 12;
        p1.Sugar = 50;
        p1.Flavor = "Кока-Кола";
        p1.Stick = true;



        var p2 = new Marmalade();
        p2.Name = "Кислые мармеладные Червячки";
        p2.Price = 10;
        p2.Weight = 5;
        p2.Sprinkling = true;
        p2.Form = "Червячки";

        var p3 = new Chocolate();
        p3.Name = "Горький шоколад Бабаевский";
        p3.Price = 67;
        p3.Weight = 55;
        p3.Nuts = false;
        p3.Bitterness = 75;


        var p4 = new Filled();
        p4.Name = "Карамель с марципаном";
        p4.Price = 15;
        p4.Weight = 7;
        p4.Sugar = 85;
        p4.Humidity = 10;




        var listObject = new Gift();
        listObject.ListOfSweets.Add(p1);
        listObject.ListOfSweets.Add(p2);
        listObject.ListOfSweets.Add(p3);
        listObject.ListOfSweets.Add(p3);


        foreach (IPrint p in listObject.ListOfSweets)
        {
            listObject.ShowInfo(p);
            Console.WriteLine();
            Console.WriteLine();
        }

        listObject.WeightCount();

        Console.ReadKey();
    }
}