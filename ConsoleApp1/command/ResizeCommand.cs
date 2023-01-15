namespace DesignPatterns.command;

public class ResizeCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("resize command...");
    }
}