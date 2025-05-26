namespace LibraryMgmt;

public class ReturnEventArgs
{
    public LibraryItem ReturnedItem { get; }
    public string BorrowerId { get; }
    public DateTime ReturnDate { get; }
    public bool IsOverdue { get; }

    public ReturnEventArgs(LibraryItem returnedItem, string borrowerId, DateTime returnDate, bool isOverdue)
    {
        ReturnedItem = returnedItem;
        BorrowerId = borrowerId;
        ReturnDate = returnDate;
        IsOverdue = isOverdue;
    }
}