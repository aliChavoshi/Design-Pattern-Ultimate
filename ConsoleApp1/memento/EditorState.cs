namespace DesignPatterns.memento;

public class EditorState
{
    private readonly string _content;

    public EditorState(string content)
    {
        _content = content;
    }

    public string GetContent()
    {
        return _content;
    }
}