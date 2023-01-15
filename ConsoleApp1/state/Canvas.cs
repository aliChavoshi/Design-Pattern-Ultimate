namespace DesignPatterns.state;

public class Canvas
{
    //composition
    private readonly ITool _currentTool;

    public Canvas(ITool currentTool)
    {
        _currentTool = currentTool;
    }

    public void MouseUp()
    {
        _currentTool.MouseUp();
    }

    public void MouseDown()
    {
        _currentTool.MouseDown();
    }
}