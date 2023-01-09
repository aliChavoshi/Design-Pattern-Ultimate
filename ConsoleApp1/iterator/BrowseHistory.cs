namespace ConsoleApp1.iterator;

public class BrowseHistory<T>
{
    private readonly Stack<string> _urls = new();

    public void Push(string url)
    {
        _urls.Push(url);
    }

    public string Pop()
    {
        return _urls.Pop();
    }

    public Stack<string> GetUrls()
    {
        return _urls;
    }

    public Iterator<T> CreateIterator(Iterator<T> iterator)
    {
        return iterator;
    }
}