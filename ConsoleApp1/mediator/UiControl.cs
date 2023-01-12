namespace ConsoleApp1.mediator;

public class UiControl
{
    protected readonly Mediator Owner;

    public UiControl(Mediator owner)
    {
        Owner = owner;
    }
}