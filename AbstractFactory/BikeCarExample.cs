
using AbstractFactory;

namespace AbstractFactory;


//Product: Bike, Car. Product Type: Sport, Regular
/// <summary>
/// Console.WriteLine("Fetching RegularBike Details..");
/// </summary>
/// 

public interface IVehicle
{
    void GetDetails();
}
public interface IBike: IVehicle
{
}

public interface ICar :IVehicle
{
}

public class RegularBike : IBike
{
    public void GetDetails()
    {
        Console.WriteLine("Fetching Regular Bike Details..");
    }
}
public class SportBike : IBike
{
    public void GetDetails()
    {
        Console.WriteLine("Fetching Sport Bike Details..");
    }
}

public class RegularCar : ICar
{
    public void GetDetails()
    {
        Console.WriteLine("Fetching Regular Car Details..");
    }
}
public class SportCar : ICar
{
    public void GetDetails()
    {
        Console.WriteLine("Fetching Sport Car Details..");
    }
}

public interface IVehicleFactory
{
    IVehicle CreateBike();
    IVehicle CreateCar();
}

public class RegularVehicleFactory : IVehicleFactory
{
    IVehicle IVehicleFactory.CreateBike()
    {
        return new RegularBike();
    }

    IVehicle IVehicleFactory.CreateCar()
    {
        return new RegularCar();
    }
}

public class SportVehicleFactory : IVehicleFactory
{
    public IVehicle CreateBike()
    {
        return new SportBike();
    }

    public IVehicle CreateCar()
    {
        return new SportCar();
    }
}