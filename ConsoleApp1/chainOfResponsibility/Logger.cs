namespace DesignPatterns.chainOfResponsibility;

public class Logger : Handler
{
    public void Log(HttpRequest request)
    {
        Console.WriteLine("Log");
    }

    public Logger(Handler next) : base(next)
    {
    }

    protected override bool DoHandle(HttpRequest request)
    {
        Log(request);
        return true;
    }
}