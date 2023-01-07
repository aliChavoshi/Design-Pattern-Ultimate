namespace ConsoleApp1.state;
//inheritance
public class EraserTool : ITool
{
    public void MouseUp()
    {
        Console.WriteLine("eraser mouse up");
    }

    public void MouseDown()
    {
        Console.WriteLine("eraser mouse down");
    }
}