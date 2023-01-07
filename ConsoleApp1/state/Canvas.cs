namespace ConsoleApp1.state;

public class Canvas
{
    //composition
    private readonly ITool _currentToolType;

    public Canvas(ITool currentToolType)
    {
        _currentToolType = currentToolType;
    }

    public void MouseUp()
    {
        _currentToolType.MouseUp();
    }

    public void MouseDown()
    {
        _currentToolType.MouseDown();
    }
}