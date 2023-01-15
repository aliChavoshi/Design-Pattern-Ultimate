namespace DesignPatterns.memento.Exercise;

public class DocumentState
{
    public string Content { get; set; }
    public string FontSize { get; set; }
    public string FontName { get; set; }

    public DocumentState(string content, string fontSize, string fontName)
    {
        Content = content;
        FontSize = fontSize;
        FontName = fontName;
    }
}