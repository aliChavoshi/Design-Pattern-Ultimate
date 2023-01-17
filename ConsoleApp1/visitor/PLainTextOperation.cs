namespace DesignPatterns.visitor;

public class PLainTextOperation : IOperation
{
    public void Apply(HeadingNode headingNode)
    {
        Console.WriteLine("heading plain text");
    }

    public void Apply(AnchorNode anchorNode)
    {
        Console.WriteLine("anchor plain text");
    }
}