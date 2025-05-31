namespace DesignPatterns.Behavioural.Observer;

public class Sheet : IObserver
{
    private DataSource _dataSource;
    private int _total;

    public Sheet(DataSource dataSource)
    {
        _dataSource = dataSource;
    }

    public int GetTotal()
    {
        return _total;
    }

    public void Update()
    {
        Console.WriteLine("Rendering Sheet with new values");
    }

    public int CalculateTotal(List<int> values)
    {
        var sum = 0;
        foreach (var value in values)
        {
            sum+=value;
        }

        Console.WriteLine($"Total: {sum}");
        return sum;
    }
}