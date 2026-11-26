namespace Librarys.Models;

public class Book : LibraryItem
{
    public string Author { get; }
    public int PageCount { get; }

    public Book(int id, string title, int publishedYear, string author, int pageCount)
        : base(id, title, publishedYear)
    {
        this.Author = author;
        this.PageCount = pageCount;
    }

    public override string TypeName => "Kitob";

    public override int MaxLoanDays => 14;

    public override string GetSummary()
    {
        return 
        $"""
            {base.GetSummary()},
            Author: {this.Author},
            PageCount: {this.PageCount},
            TypeName: {this.TypeName},
            MaxLoanDays: {this.MaxLoanDays}.
        """;
    }
}
