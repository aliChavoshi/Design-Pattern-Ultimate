namespace DesignPatterns.iterator;

public abstract class Iterator<T>
{
    public abstract void Next();
    public abstract T Current();
    public abstract bool HasNext();
}