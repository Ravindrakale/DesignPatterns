public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("-------------------------------List Of Toys--------------------------------------------");
        var toyACreator = new ToyCreator(new ToyABuilder());
        toyACreator.CreateToy();
        DisplayToyDetails(toyACreator.GetToy());
        var toyBCreator = new ToyCreator(new ToyBBuilder());
        toyBCreator.CreateToy();
        DisplayToyDetails(toyBCreator.GetToy());
    }

    public static void DisplayToyDetails(Toy toy)
    {
        Console.WriteLine($"Model: {toy.Model}");
        Console.WriteLine($"Head: {toy.Head}");
        Console.WriteLine($"Limb: {toy.Limbs}");
        Console.WriteLine($"Body: {toy.Body}");
        Console.WriteLine($"Legs: {toy.Legs}");
        Console.WriteLine("------------------------------");
    }
}


//This is the product class for Toy.
public class Toy
{
    public string Model { get; set; }
    public string Head { get; set; }
    public string Limbs { get; set; }
    public string Body { get; set; }
    public string Legs { get; set; }
}

public interface IToyBuilder
{
    void SetModel();
    void SetHead();
    void SetLimbs();
    void SetBody();
    void SetLegs();
    Toy GetToy();
}

public class ToyABuilder : IToyBuilder
{
    Toy toy = new Toy();
    public void SetModel()
    {
        toy.Model = "TOY A";
    }
    public void SetHead()
    {
        toy.Head = "1";
    }
    public void SetLimbs()
    {
        toy.Limbs = "4";
    }
    public void SetBody()
    {
        toy.Body = "Plastic";
    }
    public void SetLegs()
    {
        toy.Legs = "2";
    }
    public Toy GetToy()
    {
        return toy;
    }
}

public class ToyBBuilder : IToyBuilder
{
    Toy toy = new Toy();
    public void SetModel()
    {
        toy.Model = "TOY B";
    }
    public void SetHead()
    {
        toy.Head = "1";
    }
    public void SetLimbs()
    {
        toy.Limbs = "4";
    }
    public void SetBody()
    {
        toy.Body = "Steel";
    }
    public void SetLegs()
    {
        toy.Legs = "4";
    }
    public Toy GetToy()
    {
        return toy;
    }
}

public class ToyCreator
{
    private IToyBuilder _toyBuilder;
    public ToyCreator(IToyBuilder toyBuilder)
    {
        _toyBuilder = toyBuilder;
    }
    public void CreateToy()
    {
        _toyBuilder.SetModel();
        _toyBuilder.SetHead();
        _toyBuilder.SetLimbs();
        _toyBuilder.SetBody();
        _toyBuilder.SetLegs();
    }
    public Toy GetToy()
    {
        return _toyBuilder.GetToy();
    }
}