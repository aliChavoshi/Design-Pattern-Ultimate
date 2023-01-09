namespace ConsoleApp1.strategy;

public class BlackAndWhite : IFilter
{
    public void Apply()
    {
        Console.WriteLine("bw filter");
    }
}