namespace DesignPatterns.command;

public class Button
{
    private readonly ICommand _command;

    public Button(ICommand command, string label)
    {
        _command = command;
        Label = label;
    }

    public string Label { get; set; }

    public void Click()
    {
        _command.Execute();
    }
}