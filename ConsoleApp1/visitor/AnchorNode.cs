namespace DesignPatterns.visitor;

public class AnchorNode : IHtmlNode
{
    public void Highlight()
    {
        Console.WriteLine("anchor highlight");
    }
}