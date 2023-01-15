namespace DesignPatterns.observer;

public class Chart : IObserver
{
    private readonly DataSource _dataSource;

    public Chart(DataSource dataSource)
    {
        _dataSource = dataSource;
    }

    public void Update()
    {
        Console.WriteLine($"chart updated {_dataSource.Value}");
    }
}