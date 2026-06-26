/// <summary>
/// Defination:
/// a creational design pattern that defines an interface or abstract class for creating an object,
/// but delegates the instantiation logic to its subclasses.
/// This allows your application to remain loosely coupled, satisfying the Open-Closed Principle by letting
/// you add new concrete product types without modifying the core client code.
///  
/// Usage:
/// Varying Dependents: The exact types of objects your code needs to work with cannot be predicted beforehand.
/// Framework Extensibility: You want to provide users of your library or framework with a clean way to extend its internal components.
/// Encapsulation: You need to save system resources by reusing existing objects instead of rebuilding them each time (e.g., caching/pooling).
/// 
/// </summary>
/// 

namespace FactoryMethod;
public class Program
{
    public static void Main(string[] args)
    {
        {
            var factory = new NewCustomNotificationFactory();

            factory.DeliverMessage("some notification");

            Console.WriteLine("Hello, World!");

        }
    }
}

public interface INotification
{
    void Send(string message);
}

public class SmsNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"[SMS] Sent: {message}");
    }
}

public class EmailNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"[Email] Sent: {message}");
    }
}

public class NewCustomNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"[Custom] Sent: {message}");
    }
}

public abstract class NotificationFactory
{
    public abstract INotification CreateNotification();

    public void DeliverMessage(string message)
    {
        INotification notification = CreateNotification();
        notification.Send(message);
    }
}

// Concrete Creator A
public class EmailNotificationFactory : NotificationFactory
{
    public override INotification CreateNotification() => new EmailNotification();
}

// Concrete Creator B
public class SmsNotificationFactory : NotificationFactory
{
    public override INotification CreateNotification() => new SmsNotification();
}

// Concreate Creator C
public class NewCustomNotificationFactory : NotificationFactory
{
    public override INotification CreateNotification()
    {
        return new NewCustomNotification();
    }
}