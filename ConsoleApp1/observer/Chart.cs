namespace ConsoleApp1.observer;

public class Chart : IObserver
{
    public void Update()
    {
        Console.WriteLine("chart updated...");
    }
}