namespace DesignPatterns.strategy;

public class BlackAndWhite : IFilter
{
    public void Apply()
    {
        Console.WriteLine("bw filter");
    }
}