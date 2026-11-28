using Librarys.Commons;

namespace Librarys.Models;

public class Loan : IDisplayable
{
    public int Id { get; }
    public int ItemId { get; }
    public int MemberId { get; }
    public bool IsReturned { get; private set; } = false;
    public int DaysKept { get; private set; }
    public decimal Fine { get; private set; }

    public Loan(int id, int itemId, int memberId)
    {
        Id = id;
        ItemId = itemId;
        MemberId = memberId;
    }

    public void Close(int daysKept, decimal fine)
    {
        if (daysKept < 0)
            throw new ArgumentOutOfRangeException(nameof(daysKept));

        if (fine < 0)
            throw new ArgumentOutOfRangeException(nameof(fine));
        
        DaysKept = daysKept;
        Fine = fine;
        IsReturned = true;
    }


    public string GetSummary()
    {
        return
        $"""
        Id : {Id}
        ItemId : {ItemId}
        MemberId : {MemberId}
        IsReturned : {IsReturned}
        DeysKept : {DaysKept}
        Fine : {Fine}
        """;
    }
}