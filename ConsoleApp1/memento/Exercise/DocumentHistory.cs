namespace DesignPatterns.memento.Exercise;

public class DocumentHistory
{
    private readonly Stack<DocumentState> _states = new();

    public void Push(DocumentState state)
    {
        _states.Push(state);
    }

    public DocumentState Pop()
    {
        return _states.Pop();
    }
}