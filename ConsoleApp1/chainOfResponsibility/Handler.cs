namespace ConsoleApp1.chainOfResponsibility;

public abstract class Handler
{
    private readonly Handler? _next;

    protected Handler(Handler next)
    {
        _next = next;
    }

    public void Handle(HttpRequest request)
    {
        if (!DoHandle(request))
            return;
        _next?.Handle(request);
    }

    protected abstract bool DoHandle(HttpRequest request);
}