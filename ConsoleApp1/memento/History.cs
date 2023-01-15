namespace DesignPatterns.memento;

public class History
{
    private readonly Stack<EditorState> _states = new();

    public void Push(EditorState state)
    {
        _states.Push(state);
    }

    public EditorState Pop()
    {
        return _states.Pop();
    }
}