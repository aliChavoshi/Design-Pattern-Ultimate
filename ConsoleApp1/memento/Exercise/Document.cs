namespace DesignPatterns.memento.Exercise;

public class Document
{
    public string Content { get; set; }
    public string FontName { get; set; }
    public string FontSize { get; set; }

    public Document(string content, string fontName, string fontSize)
    {
        Content = content;
        FontName = fontName;
        FontSize = fontSize;
    }

    public DocumentState CreateState()
    {
        return new DocumentState(Content, FontSize, FontName);
    }

    public void Restore(DocumentState state)
    {
        Content = state.Content;
        FontName = state.FontName;
        FontSize = state.FontSize;
    }
}