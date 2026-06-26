/// <summary>
/// Defination:
/// Singletone design pattern that ensures a class has only one instance in memory throughout the application lifecycle
/// and provides a global point of access to that instance.
/// 
/// Usage:
/// It is commonly used for shared resources such as logging systems, database connection pools, or configuration managers
/// 
/// Key Points:
/// It should be threadsafe and Lazy
/// 
/// Key Elements:
/// sealed Keyword: Prevents class inheritance, which could otherwise compromise the single-instance constraint.
/// Private Constructor: Disables external code from using new Singleton().
/// Static Member/Property: Stores and exposes the solitary instance created within the class.
/// </summary>
/// 

ApplicationLogger.Instance.LogInfo("Application has been started");

Console.WriteLine("Hello, World!");
