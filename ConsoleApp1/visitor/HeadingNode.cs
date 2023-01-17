namespace DesignPatterns.visitor;

public class HeadingNode : IHtmlNode
{
    public void Execute(IOperation operation)
    {
        operation.Apply(this);
    }
}