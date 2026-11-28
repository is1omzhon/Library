namespace Librarys.Models;

public sealed class AudioBook : LibraryItem
{
    public string Narrator { get; }
    public int DurationMinutes { get; }
    public override string TypeName => "AudioBook";
    public override int MaxLoanDays => 10;
    public override decimal DailyFine => 1500;

    public AudioBook(int id, string title, int publishedYear, string narrator, int durationMinutes) : base(id, title, publishedYear)
    {
        Narrator = narrator;
        DurationMinutes = durationMinutes;
    }

    public override string GetSummary()
    {
        return
        $"""
            {base.GetSummary()},
            Narrator: {Narrator},
            DurationMinutes: {DurationMinutes},
            TypeName: {TypeName},
            MaxLoanDays: {MaxLoanDays},
            DailyFine: {DailyFine}
        """;
    }
}
