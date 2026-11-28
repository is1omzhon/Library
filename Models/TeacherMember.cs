using LibraryItem.Models;

namespace Librarys.Models;

public class TeacherMember : Member
{
    public string Department {get;}
    public TeacherMember(int id, string fullName, string phoneNumber, string department) : base(id, fullName, phoneNumber)
    {
        Department = department;
    }
    public override string MemberType => "Teacher";
    public override int BorrowLimit => 5;
}