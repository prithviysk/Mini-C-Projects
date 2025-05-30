namespace DesignPatterns.Behavioural.Iterator;

public interface IIterator<T>
{
    void Next();
    bool HasNext();
    T Current();
}