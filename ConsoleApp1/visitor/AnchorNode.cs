namespace DesignPatterns.visitor;

public class AnchorNode : IHtmlNode
{
    public void Execute(IOperation operation)
    {
        operation.Apply(this);
    }
}