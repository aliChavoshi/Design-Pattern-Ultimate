namespace ConsoleApp1.state;

public class BrushTool : ITool
{
    public void MouseUp()
    {
        Console.WriteLine("brush mouse up");
    }

    public void MouseDown()
    {
        Console.WriteLine("brush mouse down");
    }
}