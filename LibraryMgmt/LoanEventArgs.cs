namespace LibraryMgmt;

public class LoanEventArgs : EventArgs
{
    public LibraryItem BorroedItem { get; }
    public string BorrowerId { get; }
    public DateTime LoanDate { get; }
    public DateTime DueDate { get; }

    public LoanEventArgs(LibraryItem borroedItem, string borrowerId, DateTime loanDate, DateTime dueDate)
    {
        BorroedItem = borroedItem;
        BorrowerId = borrowerId;
        LoanDate = loanDate;
        DueDate = dueDate;
    }
}