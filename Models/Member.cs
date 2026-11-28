using System.Dynamic;
using Librarys.Commons;

namespace LibraryItem.Models;

public abstract class Member : IDisplayable
{
    public int Id { get; private set; }
    public string FullName { get; private set; }
    public string PhoneNumber { get; private set; }
    public int ActiveLoanCount { get; private set; } 
    public abstract string MemberType { get; }
    public abstract int BorrowLimit { get; }

    protected Member(int id, string fullName, string phoneNumber)
    {
        SetId(id);
        SetFullName(fullName);
        SetPhoneNumber(phoneNumber);
    }

    public bool CanBorrow()
    {
        if(ActiveLoanCount < BorrowLimit)
            return true;
        else
            return false;
    }

    public virtual decimal CalculateFine(int lateDays, decimal dailyFine)
    {
        if(lateDays <= 0)
        {
            return 0;
        }
        else
        {
            return lateDays * dailyFine;
        }
    }

    public void UpdateContact(string fullName, string phoneNumber)
    {
        SetFullName(fullName);
        SetPhoneNumber(phoneNumber);
    }

    public void IncreaseActiveLoans()
    {
        ActiveLoanCount++;
    }

    public void DecreaseActiveLoans()
    {
        if(ActiveLoanCount > 0)
            ActiveLoanCount--;
    }

    public string GetSummary()
    {
        return
        $"""
        Id : {Id},
        FullName : {FullName},
        PhoneNumber : {PhoneNumber},
        ActiveLoanCount : {ActiveLoanCount},
        MemberType : {MemberType},
        BorrowLimit : {BorrowLimit}
        """;
    }
    
    private void SetId(int id)
    {
        if (id > 0)
            Id = id;
    }
    private void SetFullName(string fullName)
    {
        if (string.IsNullOrWhiteSpace(fullName))
            throw new Exception ("Fulname bush bula olmaydi!");

        this.FullName = fullName;
    }
    private void SetPhoneNumber(string phoneNumber)
    {
        if (string.IsNullOrWhiteSpace(phoneNumber))
            throw new Exception ("Fulname bush bula olmaydi!"); 

        this.PhoneNumber = phoneNumber;
    }

}