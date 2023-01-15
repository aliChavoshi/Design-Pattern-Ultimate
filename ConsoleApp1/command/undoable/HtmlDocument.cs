namespace DesignPatterns.command.undoable;

public class HtmlDocument
{
    public string Content { get; set; }

    public void MakeBold()
    {
        Content = "<b>" + Content + "</b>";
    }

    public void MakeItalic()
    {
        Content = $"<i>${Content}</i>";
    }
}