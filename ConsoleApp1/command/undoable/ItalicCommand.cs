namespace DesignPatterns.command.undoable;

public class ItalicCommand : IUndoAbleCommand
{
    public string PrevContent { get; set; }
    private readonly History _history;
    private readonly HtmlDocument _document;

    public ItalicCommand(History history, HtmlDocument document)
    {
        _history = history;
        _document = document;
    }

    public void Execute()
    {
        PrevContent = _document.Content;
        _document.MakeItalic();
        _history.Push(this);
    }

    public void UnExecute()
    {
        _document.Content = PrevContent;
    }
}