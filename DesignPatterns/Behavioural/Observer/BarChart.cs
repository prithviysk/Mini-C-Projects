namespace DesignPatterns.Behavioural.Observer;

public class BarChart : IObserver
{
    private DataSource _dataSource;

    public BarChart(DataSource dataSource)
    {
        _dataSource = dataSource;
    }

    public void Update()
    {
        Console.WriteLine("Rendering bar chart with new values");
    }
}