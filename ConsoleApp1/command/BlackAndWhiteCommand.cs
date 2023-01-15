namespace DesignPatterns.command;

public class BlackAndWhiteCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("black and white command...");
    }
}