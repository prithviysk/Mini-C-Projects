namespace LibraryMgmt;

public class Magazines : LibraryItem
{
    public int IssueNumber { get; private set; }
    public DateTime PublicationDate { get; private set; }
    
    private bool _isOnLoan;
    private string? _currentBorrowerId;
    private DateTime? _dueDate;
    
    public bool IsOnLoan => _isOnLoan;
    public string? CurrentBorrowerId => _currentBorrowerId;
    public DateTime? DueDate => _dueDate;
    
    public event EventHandler<LoanEventArgs>? ItemLoaned;
    public event EventHandler<ReturnEventArgs>? ItemReturned;

    public Magazines(string itemID, string title, int issueNumber, DateTime publicationDate)
        : base(itemID, title)
    {
        IssueNumber = issueNumber;
        PublicationDate = publicationDate;
        _isOnLoan = false;
        _currentBorrowerId = null;
        _dueDate = null;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"  Type: Magazine");
        Console.WriteLine($"  Issue: #{IssueNumber}");
        Console.WriteLine($"  Published: {PublicationDate.ToShortDateString()}");
        Console.WriteLine($"  Status: {(IsAvailable ? "Available" : $"On Loan to {CurrentBorrowerId} (Due: {DueDate?.ToShortDateString()})")}");
    }

    public override string GetSummary()
    {
        return $"Magazine: \"{Title}\" Issue #{IssueNumber} ({PublicationDate.ToShortDateString()}) (ID: {ItemId})";
    }

    public void Loan(string borrowerId, DateTime loanDate, DateTime dueDate)
    {
        if (IsAvailable)
        {
            _isOnLoan = true;
            _currentBorrowerId = borrowerId;
            _dueDate = dueDate;
            SetAvailability(false);
            Console.WriteLine($"- Magazine '{Title}' (Issue #{IssueNumber}) loaned to {borrowerId}. Due on {dueDate.ToShortDateString()}.");
            
            OnItemLoaned(new LoanEventArgs(this, borrowerId, loanDate, dueDate));
        }
        else
        {
            Console.WriteLine($"- Magazine '{Title}' (ID: {ItemId}) is currently not available for loan.");
        }
    }

    public void Return(DateTime returnDate)
    {
        if (_isOnLoan)
        {
            Console.WriteLine($"- Magazine '{Title}' (Issue #{IssueNumber}) returned by {CurrentBorrowerId} on {returnDate.ToShortDateString()}.");
            if (returnDate > DueDate)
            {
                Console.WriteLine($"  (Note: This item was overdue!)");
            }
            string tempBorrowerId = CurrentBorrowerId;
            _isOnLoan = false;
            _currentBorrowerId = null;
            _dueDate = null;
            SetAvailability(true);
            
            OnItemReturned(new  ReturnEventArgs(this, tempBorrowerId, returnDate, returnDate>DueDate));
        }
        else
        {
            Console.WriteLine($"- Magazine '{Title}' (ID: {ItemId}) was not currently on loan.");
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