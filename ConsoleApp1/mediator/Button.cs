namespace ConsoleApp1.mediator;

public class Button : UiControl
{
    private bool _isEnabled;

    public bool IsEnabled
    {
        get => _isEnabled;
        set
        {
            _isEnabled = value;
            Owner.Changed(this);
        }
    }

    public Button(Mediator owner) : base(owner)
    {
    }
}