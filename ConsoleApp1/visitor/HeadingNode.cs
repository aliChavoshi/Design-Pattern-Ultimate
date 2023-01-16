namespace DesignPatterns.visitor;

public class HeadingNode : IHtmlNode
{
    public void Highlight()
    {
        Console.WriteLine("heading highlight");
    }
}