namespace ConsoleApp1.mediator;

public class TextBox : UiControl
{
    private string _content;

    public string Content
    {
        get => _content;
        set
        {
            _content = value;
            Owner.Changed(this);
        }
    }

    public TextBox(Mediator owner) : base(owner)
    {
    }
}