namespace DesignPatterns.memento;

public class Editor
{
    private string _content;

    public EditorState CreateState()
    {
        return new EditorState(_content);
    }

    public void Restore(EditorState state)
    {
        _content = state.GetContent();
    }

    public void SetContent(string value)
    {
        _content = value;
    }

    public string GetContent()
    {
        return _content;
    }
}