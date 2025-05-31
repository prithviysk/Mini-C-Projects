namespace DesignPatterns.Behavioural.Observer;

public class DataSource : Subject
{
    private List<int> _values = new List<int>();
    private List<Object> _dependants = new List<Object>();

    public List<int> GetValues()
    {
        return _values;
    }

    public void SetValues(List<int> values)
    {
        _values = values;
        
        NotifyObservers();
    }
}