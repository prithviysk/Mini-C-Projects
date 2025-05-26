namespace LibraryMgmt;

public interface ILoanable
{
    bool IsOnLoan { get; }
    string? CurrentBorrowerId { get; }
    DateTime? DueDate { get; }

    void Loan(string borrowerId, DateTime loanDate, DateTime dueDate);
    void Return(DateTime returnDate);
}