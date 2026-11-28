using Librarys.Commons;
using Librarys.Models;

public class LeonService(ILibraryItemService itemService, IMemberService memberService) : ILoanService
{
    private readonly ILibraryItemService _itemService = itemService;
    private readonly IMemberService _memberService = memberService;
    private readonly List<Loan> _loans = new();
    private int _nextLoanId = 1;

    public OperationResult BorrowItem(int memberId, int itemId)
    {
        throw new NotImplementedException();
    }

    public Loan[] GetActiveLoans()
    {
        throw new NotImplementedException();
    }

    public Loan[] GetLoansByMember(int memberId)
    {
        throw new NotImplementedException();
    }

    public decimal GetTotalFines()
    {
        throw new NotImplementedException();
    }

    public OperationResult ReturnItem(int itemId, int daysKept)
    {
        throw new NotImplementedException();
    }
}
