namespace ConsoleApp1.chainOfResponsibility;

public class Authenticator : Handler
{
    public bool Authenticate(HttpRequest request)
    {
        Console.WriteLine("Authenticate");
        return request.Username == "admin" && request.Password == "1234";
    }

    public Authenticator(Handler next) : base(next)
    {
    }

    protected override bool DoHandle(HttpRequest request)
    {
        return Authenticate(request);
    }
}