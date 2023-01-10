namespace ConsoleApp1.command.undoable;

public class UndoCommand : ICommand
{
    private readonly History _history;

    public UndoCommand(History history)
    {
        _history = history;
    }

    public void Execute()
    {
        if (_history.Size() > 0)
            _history.Pop().UnExecute();
    }
}