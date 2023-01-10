namespace ConsoleApp1.command.undoable;

public class History
{
    private readonly Stack<IUndoAbleCommand> _history = new();

    public void Push(IUndoAbleCommand command)
    {
        _history.Push(command);
    }

    public IUndoAbleCommand Pop()
    {
        return _history.Pop();
    }

    public int Size()
    {
        return _history.Count;
    }
}