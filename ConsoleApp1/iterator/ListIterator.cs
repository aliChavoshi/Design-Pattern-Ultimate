namespace DesignPatterns.iterator;

public class ListIterator : Iterator<string>
{
    private readonly BrowseHistory<string> _browseHistory;
    private int _index = 0;

    public ListIterator(BrowseHistory<string> browseHistory)
    {
        _browseHistory = browseHistory;
    }

    public override void Next()
    {
        _index++;
    }


    public override string Current()
    {
        return GetUrls().ToArray()[_index];
    }

    public override bool HasNext()
    {
        return _index < GetUrls().Count();
    }

    private IEnumerable<string> GetUrls()
    {
        return _browseHistory.GetUrls();
    }
}