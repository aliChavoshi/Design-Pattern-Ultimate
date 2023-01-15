namespace ConsoleApp1.mediator;

public class ArticlesMediator
{
    private static readonly TextBox TextBox = new();
    private static readonly Button Button = new();
    private static readonly ListBox ListBox = new();

    public ArticlesMediator()
    {
        ListBox.Attach(new ArticleSelect());
        TextBox.Attach(new TitleChanged());
    }

    public void Initial()
    {
        ListBox.Selection = "A";
        TextBox.Content = "";
        Console.WriteLine(TextBox.Content);
        Console.WriteLine(Button.IsEnabled);
    }

    private class ArticleSelect : IEventHandler
    {
        public void Update()
        {
            TextBox.Content = ListBox.Selection;
            Button.IsEnabled = true;
        }
    }

    private class TitleChanged : IEventHandler
    {
        public void Update()
        {
            Button.IsEnabled = true;
            if (string.IsNullOrEmpty(TextBox.Content))
                Button.IsEnabled = false;
        }
    }
}