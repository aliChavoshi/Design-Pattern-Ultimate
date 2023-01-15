namespace ConsoleApp1.chainOfResponsibility;

public class Compressor : Handler
{
    public void Compress(HttpRequest request)
    {
        Console.WriteLine("Compress");
    }

    public Compressor(Handler next) : base(next)
    {
    }

    protected override bool DoHandle(HttpRequest request)
    {
        Compress(request);
        return true;
    }
}