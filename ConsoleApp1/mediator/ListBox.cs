namespace ConsoleApp1.mediator;

public class ListBox : UiControl
{
    private string _selection;

    public string Selection
    {
        get => _selection;
        set
        {
            _selection = value;
            Owner.Changed(this);
        }
    }

    public ListBox(DialogBox owner) : base(owner)
    {
    }
}