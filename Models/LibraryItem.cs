namespace Librarys.Models;

public abstract class LibraryItem 
{
    public int Id { get; }
    public string Title { get; private set; }
    public int PublishedYear { get; private set; }
    public bool IsAvailable { get; private set; }
    public abstract string TypeName { get; }
    public abstract int MaxLoanDays { get; }
    public virtual decimal DailyFine;

    protected LibraryItem(int id, string title, int publishedYear)
    {
        this.Id = id;
        this.Title = title;
        this.PublishedYear = publishedYear;
    }

    public virtual string GetSummary() 
    {
        return 
        $"""
        Id : {Id},
        Title : {Title},
        PublishedYear : {PublishedYear}
        """
    }

    public void UpdateInfo(string title, int publishedYear)
    {
        if(!string.IsNullOrWhiteSpace(title))
            this.Title = title;

        if(publishedYear > 0) 
            this.PublishedYear = publishedYear;
    }

    public void MarkAsBorrowed() 
    {
        this.IsAvailable = false;
    }

    public void MarkAsReturned()
    {   
        this.IsAvailable = true;
    }

    // private void SetTitle(string title);
    // private void SetPublishedYear(int publishedYear);

} 
