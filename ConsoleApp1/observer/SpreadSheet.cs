namespace ConsoleApp1.observer;

public class SpreadSheet : IObserver
{
    public void Update(string value)
    {
        Console.WriteLine($"spread sheet updated {value}");
    }
}