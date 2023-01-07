namespace ConsoleApp1.Draw;

public abstract class UiControl
{
    public void Enable()
    {
        Console.WriteLine("enable...");
    }

    public void Focus()
    {
        Console.WriteLine("focus...");
    }

    public abstract void Draw();
}