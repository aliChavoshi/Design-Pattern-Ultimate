namespace ConsoleApp1.iterator;

public class StackIterator : Iterator<string>
{
    private readonly BrowseHistory<string> _browseHistory;
    private int _index = 0;

    public StackIterator(BrowseHistory<string> browseHistory)
    {
        _browseHistory = browseHistory;
    }

    public override void Next()
    {
        _index++;
    }

    public override string Current()
    {
        return _browseHistory.GetUrls().ToArray()[_index];
    }

    public override bool HasNext()
    {
        return _index < _browseHistory.GetUrls().Count;
    }
}