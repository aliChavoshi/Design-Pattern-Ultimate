namespace DesignPatterns.strategy;

public class HighContrast : IFilter
{
    public void Apply()
    {
        Console.WriteLine("high contrast filter");
    }
}