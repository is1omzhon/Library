namespace Librarys.Models;

public class Magazine : LibraryItem
{
    public int IssueNumber { get; }

    public Magazine(int id, string title, int publishedYear, int issueNumber)
        : base(id, title, publishedYear)
    {
        IssueNumber = issueNumber;
    }

    public override string TypeName => "Jurnal";

    public override int MaxLoanDays => 7;

    public override decimal DailyFine => 500;

    public override string GetSummary()
    {
        return
        $"""
        {base.GetSummary()}
        IssueNumber: {IssueNumber}
        TypeName: {TypeName}
        MaxLoanDays: {MaxLoanDays}
        DailyFine: {DailyFine}
        """;
    }
}