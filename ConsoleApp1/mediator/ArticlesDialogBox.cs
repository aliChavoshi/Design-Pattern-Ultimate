namespace ConsoleApp1.mediator;

public class ArticlesDialogBox : DialogBox
{
    private readonly ListBox _listBox;
    private readonly TextBox _textBox;
    private readonly Button _button;

    public ArticlesDialogBox()
    {
        _textBox = new TextBox(this);
        _listBox = new ListBox(this);
        _button = new Button(this);
    }

    public void Initial()
    {
        _listBox.Selection = "Text One";
        _textBox.Content = "";
        Console.WriteLine("text box:" + _textBox.Content);
        Console.WriteLine("button:" + _button.IsEnabled);
    }

    public override void Changed(UiControl control)
    {
        if (control == _listBox)
        {
            _textBox.Content = _listBox.Selection;
            _button.IsEnabled = true;
        }
        else if (control == _textBox)
        {
            var content = _textBox.Content;
            var isEmpty = string.IsNullOrEmpty(content);
            _button.IsEnabled = !isEmpty;
        }
    }
}