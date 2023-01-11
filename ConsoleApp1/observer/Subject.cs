namespace ConsoleApp1.observer;

public class Subject
{
    private readonly List<IObserver> _observers = new();

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers(string value)
    {
        foreach (var observer in _observers)
            observer.Update(value);
    }
}