namespace ConsoleApp1.observer;

public class Chart : IObserver
{

    public void Update(string value)
    {
        Console.WriteLine($"chart updated {value}");

    }
}