namespace ConsoleApp1.command.undoable;

public class BoldCommand : IUndoAbleCommand
{
    public string PrevContent { get; set; }
    private readonly History _history;
    private readonly HtmlDocument _htmlDocument;

    public BoldCommand(History history, HtmlDocument htmlDocument)
    {
        _history = history;
        _htmlDocument = htmlDocument;
    }

    public void Execute()
    {
        PrevContent = _htmlDocument.Content; //copy old value after that changing the value to bold
        _htmlDocument.MakeBold(); // change content in html document
        _history.Push(this); //save all values
    }

    public void UnExecute()
    {
        _htmlDocument.Content = PrevContent; // copy old value to document
    }
}