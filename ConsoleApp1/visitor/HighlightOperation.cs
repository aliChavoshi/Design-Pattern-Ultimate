namespace DesignPatterns.visitor;

public class HighlightOperation : IOperation
{
    public void Apply(HeadingNode headingNode)
    {
        Console.WriteLine("heading highlight");
    }

    public void Apply(AnchorNode anchorNode)
    {
        Console.WriteLine("anchor highlight");
    }
}