using DesignPatterns.Behavioural.Iterator;

namespace DesignPatterns.Behavioural.Memento;

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
        
        
        ShoppingList list = new ShoppingList();
        
        list.Push("Milk");
        list.Push("Cheese");
        list.Push("Tomato");

        var iterator = list.CreateIterator();

        while (iterator.HasNext())
        {
            Console.WriteLine(iterator.Current());
            iterator.Next();
        }

    }
}