
using AbstractFactory;
using System.Reflection.Metadata.Ecma335;

/// <summary>
/// Defination:
/// Abstract Factory is a creational design pattern that lets you produce families of related objects without specifying their concrete classes.
/// Abstract Factory, it is Concrete Factory creates a Concrete Product, and Concrete Factory implements Abstract Factory, and Concrete Product implements Abstract Product.  
/// </summary>

public class Program
{
    public static void Main(string[] args)
    {

        #region Old Code
        /*
        int design;
        int furniture;
        do
        {
            Console.WriteLine("Please select your desired design style:");
            Console.WriteLine("[1]Classic, [2]Contemporary, [3]Scandinavian");
            int.TryParse(Console.ReadLine(), out design);
        } while (design == 0 || design > 3);

        switch (design)
        {
            case 1: //Classic
                do
                {
                    Console.WriteLine("Seems like you prefer Classic design!");
                    Console.WriteLine("Please select your desired furniture :");
                    Console.WriteLine("[1]Cabinet, [2]Chair, [3]Dining Table");
                    int.TryParse(Console.ReadLine(), out furniture);
                }
                while (furniture == 0 || furniture > 3);

                switch (furniture)
                {
                    case 1: //Cabinet
                        Console.WriteLine("Terrific choice! We sell the best cabinet in the town!");
                        ContemporaryCabinet cabinet = new ContemporaryCabinet();
                        cabinet.ShowStyle();
                        cabinet.FurnitureFunction();
                        break;
                    case 2: //Chair
                        Console.WriteLine("Terrific choice! We sell the best chair in the town!");
                        ContemporaryChair chair = new ContemporaryChair();
                        chair.ShowStyle();
                        chair.FurnitureFunction();
                        break;
                    case 3: //Dinning table
                        Console.WriteLine("Terrific choice! We sell the best dining table in the town!");
                        ContemporaryDiningTable diningtable = new ContemporaryDiningTable();
                        diningtable.ShowStyle();
                        diningtable.FurnitureFunction();
                        break;
                }
                break;
            case 2: //Contemporary
                do
                {
                    Console.WriteLine("Seems like you prefer Contemporary design!");
                    Console.WriteLine("Please select your desired furniture :");
                    Console.WriteLine("[1]Cabinet, [2]Chair, [3]Dining Table");
                    int.TryParse(Console.ReadLine(), out furniture);
                }
                while (furniture == 0 || furniture > 3);

                switch (furniture)
                {
                    case 1: //Cabinet
                        Console.WriteLine("Terrific choice! We sell the best cabinet in the town!");
                        ContemporaryCabinet cabinet = new ContemporaryCabinet();
                        cabinet.ShowStyle();
                        cabinet.FurnitureFunction();
                        break;
                    case 2: //Chair
                        Console.WriteLine("Terrific choice! We sell the best chair in the town!");
                        ContemporaryChair chair = new ContemporaryChair();
                        chair.ShowStyle();
                        chair.FurnitureFunction();
                        break;
                    case 3: //Dinning table
                        Console.WriteLine("Terrific choice! We sell the best dining table in the town!");
                        ContemporaryDiningTable diningtable = new ContemporaryDiningTable();
                        diningtable.ShowStyle();
                        diningtable.FurnitureFunction();
                        break;
                }
                break;

            case 3: //Scandinavian
                do
                {
                    Console.WriteLine("Seems like you prefer Scandinavian design!");
                    Console.WriteLine("Please select your desired furniture :");
                    Console.WriteLine("[1]Cabinet, [2]Chair, [3]Dining Table");
                    int.TryParse(Console.ReadLine(), out furniture);
                }
                while (furniture == 0 || furniture > 3);

                switch (furniture)
                {
                    case 1: //Cabinet
                        Console.WriteLine("Terrific choice! We sell the best cabinet in the town!");
                        ContemporaryCabinet cabinet = new ContemporaryCabinet();
                        cabinet.ShowStyle();
                        cabinet.FurnitureFunction();
                        break;
                    case 2: //Chair
                        Console.WriteLine("Terrific choice! We sell the best chair in the town!");
                        ContemporaryChair chair = new ContemporaryChair();
                        chair.ShowStyle();
                        chair.FurnitureFunction();
                        break;
                    case 3: //Dinning table
                        Console.WriteLine("Terrific choice! We sell the best dining table in the town!");
                        ContemporaryDiningTable diningtable = new ContemporaryDiningTable();
                        diningtable.ShowStyle();
                        diningtable.FurnitureFunction();
                        break;
                }
                break;

        }*/
        #endregion


        //int style = 0;
        //do
        //{
        //    Console.WriteLine("Please select your desired design style:");
        //    Console.WriteLine("[1]Classic, [2]Contemporary, [3]Scandinavian");
        //    int.TryParse(Console.ReadLine(), out style);
        //} while (style == 0 || style > 3);

        //IFurnitureFactory furnitureFactory = style switch
        //{
        //    1 => new ClassicFurnitureFactory(),
        //    2 => new ContemporaryFurnitureFactory(),
        //    3 => new ScandinavianFurnitureFactory(),
        //    _ => throw new NotImplementedException()
        //};

        //int furnitureType;
        //do
        //{
        //    Console.WriteLine("Please select your furniture :");
        //    Console.WriteLine("[1]Cabinet, [2]Chair, [3]Dining Table");
        //    int.TryParse(Console.ReadLine(), out furnitureType);
        //} while (style == 0 || style > 3);

        //IFurniture furnitureProduct = style switch
        //{
        //    1 => furnitureFactory.CreateCabinet(),
        //    2 => furnitureFactory.CreateChair(),
        //    3 => furnitureFactory.CreateDiningTable(),
        //    _ => throw new NotImplementedException()
        //};
        //Console.WriteLine("Furniture Created: ");
        //furnitureProduct.ShowStyle();
        //furnitureProduct.FurnitureFunction();
        bool exit = false;
        do
        {
            int vehile;
            int vType;
            do
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("What you wand 1. Bike  2. Car");
                int.TryParse(Console.ReadLine(), out vehile);
            } while (vehile == 0 || vehile > 2);

            var product = vehile == 1 ? "Bike" : (vehile == 2 ? "Car" : "");

            do
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine($"What type of {product} you wand 1. Regular  2. Sport");
                int.TryParse(Console.ReadLine(), out vType);
            } while (vType == 0 || vType > 2);

            IVehicleFactory factory = vType switch
            {
                1 => new RegularVehicleFactory(),
                2 => new SportVehicleFactory(),
                _ => throw new Exception("Wrong Choice")
            };

            IVehicle cProduct = vehile switch
            {
                1 => factory.CreateBike(),
                2 => factory.CreateCar(),
                _ => throw new Exception("Wrong vehicle")
            };

            cProduct.GetDetails();

            Console.WriteLine("Enter 1. Exit 2. Continoue");

            int.TryParse(Console.ReadLine(), out int choice);

            exit = choice == 1;

        } while (!exit);
    }
}