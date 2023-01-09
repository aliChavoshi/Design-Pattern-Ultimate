namespace ConsoleApp1.command;

public class CompositionCommand
{
    private readonly List<ICommand> _commands = new();

    public void Add(ICommand command)
    {
        _commands.Add(command);
    }

    public void Execute()
    {
        foreach (var command in _commands)
        {
            command.Execute();
        }
    }
}