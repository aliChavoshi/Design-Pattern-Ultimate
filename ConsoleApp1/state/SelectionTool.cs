namespace ConsoleApp1.state;

public class SelectionTool : ITool
{
    public void MouseUp()
    {
        Console.WriteLine("selection mouse up");
    }

    public void MouseDown()
    {
        Console.WriteLine("selection mouse down");
    }
}