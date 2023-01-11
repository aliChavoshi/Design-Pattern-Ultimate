namespace ConsoleApp1.observer;

public class SpreadSheet : IObserver
{
    public void Update()
    {
        Console.WriteLine("spread sheet updated...");
    }
}