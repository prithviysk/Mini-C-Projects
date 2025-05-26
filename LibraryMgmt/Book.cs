namespace LibraryMgmt;

public class Book : LibraryItem, ILoanable
{
    public string Author { get; set; }
    public string ISBN { get; set; }
    
    private bool _isOnLoan;
    private string? _currentBorrowerId;
    private DateTime? _dueDate;
    
    public bool IsOnLoan => _isOnLoan;
    public string? CurrentBorrowerId => _currentBorrowerId;
    public DateTime? DueDate => _dueDate;
    
    public event EventHandler<LoanEventArgs>? ItemLoaned;
    public event EventHandler<ReturnEventArgs>? ItemReturned;

    public Book(string author, string isbn, string itemId, string title) : base(itemId,
        title)
    {
        Author = author;
        ISBN = isbn;
        _isOnLoan = false;
        _currentBorrowerId = null;
        _dueDate = null;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"  Type: Book");
        Console.WriteLine($"  Author: {Author}");
        Console.WriteLine($"  ISBN: {ISBN}");
        Console.WriteLine($"  Status: {(IsAvailable ? "Available" : $"On Loan to {CurrentBorrowerId} (Due: {DueDate?.ToShortDateString()})")}");
    }

    public override string GetSummary()
    {
        return $"Book: \"{Title}\" by {Author} (ID: {ItemId})";
    }
    public void Loan(string borrowerId, DateTime loanDate, DateTime dueDate)
    {
        if (IsAvailable)
        {
            _isOnLoan = true;
            _currentBorrowerId = borrowerId;
            _dueDate = dueDate;
            SetAvailability(false);
            Console.WriteLine($"- Book '{Title}' loaned to {borrowerId}. Due on {dueDate.ToShortDateString()}.");
            OnItemLoaned(new LoanEventArgs(this, borrowerId, loanDate, dueDate));
        }
        else
        {
            Console.WriteLine($"- Book '{Title}' (ID: {ItemId}) is currently not available for loan.");
        }
    }

    public void Return(DateTime returnDate)
    {
        if (_isOnLoan) 
        {
            Console.WriteLine($"- Book '{Title}' returned by {CurrentBorrowerId} on {returnDate.ToShortDateString()}.");
            if (returnDate > DueDate)
            {
                Console.WriteLine($"  (Note: This item was overdue!)");
            }
            string tempBorrowerId = CurrentBorrowerId;
            _isOnLoan = false;
            _currentBorrowerId = null;
            _dueDate = null;
            SetAvailability(true);
            OnItemReturned(new ReturnEventArgs(this, tempBorrowerId, returnDate, returnDate>DueDate));
        }
        else
        {
            Console.WriteLine($"- Book '{Title}' (ID: {ItemId}) was not currently on loan.");
        }
    }

    protected virtual void OnItemLoaned(LoanEventArgs e)
    {
        ItemLoaned?.Invoke(this, e);
    }

    protected virtual void OnItemReturned(ReturnEventArgs e)
    {
        ItemReturned?.Invoke(this, e);
    }
}