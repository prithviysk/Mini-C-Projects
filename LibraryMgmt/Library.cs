namespace LibraryMgmt;

public class Library
{
    private List<LibraryItem> _items;
    public string LibraryName { get; set; }

    public Library(string name)
    {
        _items = new List<LibraryItem>();
        LibraryName = name;
    }

    public void AddItem(LibraryItem item)
    {
        _items.Add(item);
        Console.WriteLine($"- Added '{item.Title}' (ID: {item.ItemId}) to {LibraryName}.");
        SubscribeToItemEvents(item);
    }

    private void SubscribeToItemEvents(LibraryItem item)
    {
        if (item is Book book)
        {
            book.ItemLoaned += Item_ItemLoaned;
            book.ItemReturned += Item_ItemReturned;
            Console.WriteLine($"  -> Subscribed to loan/return events for '{item.Title}' (as a Book).");
        }
    }

    private void Item_ItemLoaned(object sender, LoanEventArgs e)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\n[LIBRARY NOTIFICATION]: Item '{e.BorroedItem.Title}' (ID: {e.BorroedItem.ItemId}) was LOANED.");
        Console.WriteLine($"  Loaned to: {e.BorrowerId} on {e.LoanDate.ToShortDateString()}, Due: {e.DueDate.ToShortDateString()}.");
        Console.ResetColor();
    }
    
    private void Item_ItemReturned(object? sender, ReturnEventArgs e)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"\n[LIBRARY NOTIFICATION]: Item '{e.ReturnedItem.Title}' (ID: {e.ReturnedItem.ItemId}) was RETURNED.");
        Console.WriteLine($"  Returned by: {e.BorrowerId} on {e.ReturnDate.ToShortDateString()}.");
        if (e.IsOverdue)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"  *** ATTENTION: This item was OVERDUE! ***");
        }
        Console.ResetColor();
    }
    
    public void DisplayAllItems()
    {
        Console.WriteLine($"\n--- Items in {LibraryName} ---");
        if (!_items.Any())
        {
            Console.WriteLine("No items in the library yet.");
            return;
        }

        foreach (var item in _items)
        {
            item.DisplayInfo();
            Console.WriteLine("-------------------------");
        }
    }
}