namespace DesignPatterns.visitor;

public class HtmlDocument
{
    private readonly List<IHtmlNode> _nodes = new();

    public void Add(IHtmlNode node)
    {
        _nodes.Add(node);
    }

    public void Highlight()
    {
        foreach (var node in _nodes)
        {
            node.Highlight();
        }
    }
}