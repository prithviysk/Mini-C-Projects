using DesignPatterns.Behavioural.Observer;

namespace DesignPatterns.Behavioural;

class Program
{
    static void Main(string[] args)
    {
        // var editor =  new Editor();
        // var history = new History(editor);
        //
        // history.Backup();
        // editor.Title = "Test";
        // history.Backup();
        //
        // editor.Content = "This is the content";
        // history.Backup();
        //
        // editor.Title = "Title change";
        // history.Backup();
        //
        // history.Undo();
        //
        // history.ShowHistory();
        
        
        // ShoppingList list = new ShoppingList();
        //
        // list.Push("Milk");
        // list.Push("Cheese");
        // list.Push("Tomato");
        //
        // var iterator = list.CreateIterator();
        //
        // while (iterator.HasNext())
        // {
        //     Console.WriteLine(iterator.Current());
        //     iterator.Next();
        // }
        
        
        DataSource dataSource = new DataSource();
        Sheet sheet = new Sheet(dataSource);
        BarChart barChart = new BarChart(dataSource);
        
        dataSource.AddObserver(barChart);
        dataSource.AddObserver(sheet);

        dataSource.SetValues([5, 5, 3, 4]);
        dataSource.SetValues([12, 4, 2, 1]);

    }
}