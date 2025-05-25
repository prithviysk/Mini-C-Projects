namespace LibraryMgmt;

public abstract class LibraryItem
{
    public string ItemId { get; set; }
    public string Title { get; set; }
    public bool IsAvailable { get; private set; }

    public LibraryItem(string itemId, string title)
    {
        ItemId = itemId;
        Title = title;
        IsAvailable = true;
    }
    
    public abstract void DisplayInfo();
    public abstract string GetSummary();

    public virtual void SetAvailability(bool available)
    {
        IsAvailable = available;
        Console.WriteLine($"Item '{Title}' (ID: {ItemId}) is now {(IsAvailable ? "available" : "on loan")}.");
    }
}