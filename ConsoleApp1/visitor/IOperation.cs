namespace DesignPatterns.visitor;

public interface IOperation
{
    //overloading => same name method with different signature
    void Apply(HeadingNode headingNode);
    void Apply(AnchorNode anchorNode);
}