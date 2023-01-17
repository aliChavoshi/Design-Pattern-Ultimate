namespace DesignPatterns.visitor;

public class HtmlDocument
{
    private readonly List<IHtmlNode> _nodes = new();

    public void Add(IHtmlNode node)
    {
        _nodes.Add(node);
    }

    public void Highlight(IOperation operation)
    {
        foreach (var node in _nodes) node.Execute(operation);
    }
}