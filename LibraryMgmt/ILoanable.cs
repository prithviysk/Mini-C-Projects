namespace LibraryMgmt;

public interface ILoanable
{
    public bool IsOnLoan { get; }
    public string? CurrentBorrowerId { get; }
    public DateTime? DueDate { get; }

    void Loan(string borrowerId, DateTime loanDate, DateTime dueDate);
    public void Return(DateTime returnDate);
}