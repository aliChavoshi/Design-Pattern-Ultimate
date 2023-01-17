namespace DesignPatterns.visitor;

public interface IHtmlNode
{
    // void Highlight();
    void Execute(IOperation operation);
}