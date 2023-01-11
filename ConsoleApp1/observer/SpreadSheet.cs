namespace ConsoleApp1.observer;

public class SpreadSheet : IObserver
{
    private readonly DataSource _dataSource;

    public SpreadSheet(DataSource dataSource)
    {
        _dataSource = dataSource;
    }

    public void Update()
    {
        Console.WriteLine($"spread sheet updated {_dataSource.Value}");
    }
}