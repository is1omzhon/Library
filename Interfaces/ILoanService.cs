using Librarys.Commons;
using Librarys.Models;

public interface ILoanService
{
    OperationResult BorrowItem(int memberId, int itemId);
    OperationResult ReturnItem(int itemId, int daysKept);
    Loan[] GetActiveLoans();
    Loan[] GetLoansByMember(int memberId);
    decimal GetTotalFines();
}