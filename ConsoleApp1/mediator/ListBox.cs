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
            NotifyObservers();
        }
    }
}