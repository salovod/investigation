using Serilog;

namespace SeleniumGoogleTest.com.configuration.logger;

public static class Logger
{
    
    private static readonly ILogger Log = new LoggerConfiguration()
        .WriteTo.Console()   
        .CreateLogger();

    public static void Step(string message)
    {
        Log.Debug(message);
    }
}