namespace ConsoleApp1.mediator;

public abstract class UiControl
{
    private readonly List<IEventHandler> _eventHandlers = new();

    public void Attach(IEventHandler eventHandler)
    {
        _eventHandlers.Add(eventHandler);
    }

    public void Detach(IEventHandler eventHandler)
    {
        _eventHandlers.Remove(eventHandler);
    }

    protected void NotifyObservers()
    {
        foreach (var handler in _eventHandlers)
            handler.Update();
    }
}