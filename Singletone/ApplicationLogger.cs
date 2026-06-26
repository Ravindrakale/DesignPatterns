//sealed Keyword
public sealed class ApplicationLogger
{
    // 1. A private static Lazy field initialized
    private static readonly Lazy<ApplicationLogger> _lazyInstance = new(() => new ApplicationLogger());

    // 2. A private constructor to prevent external instantiation via the 'new' keyword
    private ApplicationLogger() { }

    // 3. A public static property to provide the global access point to the single instance
    public static ApplicationLogger Instance => _lazyInstance.Value;

    public void LogInfo(string message)
    {
        Console.WriteLine($"Info: {message}");
    }

    public void LogWarning(string warning)
    {
        Console.WriteLine($"Warning: {warning}");
    }

    public void LogError(Exception ex, string? errorMessage = default)
    {
        Console.WriteLine($"Error : {(string.IsNullOrWhiteSpace(errorMessage) ? ex.Message : errorMessage)}");
    }
}