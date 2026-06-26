
namespace AbstractFactory;

public interface IFurniture
{
    void FurnitureFunction();
    void ShowStyle();
}

public interface IFurnitureFactory
{
    IFurniture CreateCabinet();
    IFurniture CreateChair();
    IFurniture CreateDiningTable();
}

public class ClassicFurnitureFactory : IFurnitureFactory
{
    public IFurniture CreateCabinet()
    {
        return new ClassicCabinet();
    }
    public IFurniture CreateChair()
    {
        return new ClassicChair();
    }
    public IFurniture CreateDiningTable()
    {
        return new ClassicDiningTable();
    }
}

public class ContemporaryFurnitureFactory : IFurnitureFactory
{
    public IFurniture CreateCabinet()
    {
        return new ClassicCabinet();
    }
    public IFurniture CreateChair()
    {
        return new ClassicChair();
    }
    public IFurniture CreateDiningTable()
    {
        return new ClassicDiningTable();
    }
}

public class ScandinavianFurnitureFactory : IFurnitureFactory
{
    public IFurniture CreateCabinet()
    {
        return new ClassicCabinet();
    }
    public IFurniture CreateChair()
    {
        return new ClassicChair();
    }
    public IFurniture CreateDiningTable()
    {
        return new ClassicDiningTable();
    }
}

public class ClassicCabinet : IFurniture
{
    public void FurnitureFunction()
    {
        Console.WriteLine("I'm used for storing item");
    }
    public void ShowStyle()
    {
        Console.WriteLine("I'm a Classical cabinet ");
    }
}

public class ClassicChair : IFurniture
{
    public void FurnitureFunction()
    {
        Console.WriteLine("I'm used for Sitting");
    }
    public void ShowStyle()
    {
        Console.WriteLine("I'm a Classical chair ");
    }
}

public class ClassicDiningTable : IFurniture
{
    public void FurnitureFunction()
    {
        Console.WriteLine("I'm used for dining");
    }
    public void ShowStyle()
    {
        Console.WriteLine("I'm a Classical Dinning table");
    }
}

public class ContemporaryCabinet : IFurniture
{
    public void FurnitureFunction()
    {
        Console.WriteLine("I'm used for storing item");
    }
    public void ShowStyle()
    {
        Console.WriteLine("I'm a Contemporary cabinet ");
    }
}

public class ContemporaryChair : IFurniture
{
    public void FurnitureFunction()
    {
        Console.WriteLine("I'm used for Sitting");
    }
    public void ShowStyle()
    {
        Console.WriteLine("I'm a Contemporary cabinet ");
    }
}

public class ContemporaryDiningTable : IFurniture
{
    public void FurnitureFunction()
    {
        Console.WriteLine("I'm used for dining");
    }
    public void ShowStyle()
    {
        Console.WriteLine("I'm a Contemporary cabinet ");
    }
}


public class ScandinavianCabinet : IFurniture
{
    public void FurnitureFunction()
    {
        Console.WriteLine("I'm used for storing item");
    }
    public void ShowStyle()
    {
        Console.WriteLine("I'm a Scandinavian cabinet ");
    }
}

public class ScandinavianChair : IFurniture
{
    public void FurnitureFunction()
    {
        Console.WriteLine("I'm used for Sitting");
    }
    public void ShowStyle()
    {
        Console.WriteLine("I'm a Scandinavian cabinet ");
    }
}

public class ScandinavianDiningTable : IFurniture
{
    public void FurnitureFunction()
    {
        Console.WriteLine("I'm used for dining");
    }
    public void ShowStyle()
    {
        Console.WriteLine("I'm a Scandinavian cabinet ");
    }
}