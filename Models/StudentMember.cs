using LibraryItem.Models;

namespace Librarys.Models;

public class StudentMember : Member
{
    public string GroupName {get;}
    public StudentMember(int id, string fullName, string phoneNumber, string groupName) : base(id, fullName, phoneNumber)
    {
        GroupName = groupName;
    }
    public override string MemberType => "Student";
    public override int BorrowLimit => 3;

    public override decimal CalculateFine(int lateDays, decimal dailyFine)
    {
        return base.CalculateFine(lateDays, dailyFine) / 2;
    }
}