namespace DesignPatterns.observer;

public class DataSource : Subject
{
    private string _value;

    public string Value
    {
        get => _value;
        set
        {
            _value = value;
            NotifyObservers();
        }
    }
}