using LibraryItem.Models;
using Librarys.Commons;

public class MemberService : IMemberService
{
    private readonly Dictionary<int, Member> _members = new();
    public OperationResult DeleteMember(int id)
    {
        throw new NotImplementedException();
    }

    public Member[] GetAllMembers()
    {
        throw new NotImplementedException();
    }

    public Member GetMemberById(int id)
    {
        throw new NotImplementedException();
    }

    public OperationResult RegisterMember(Member member)
    {
        throw new NotImplementedException();
    }

    public OperationResult UpdateMember(int id, string newFullName, string newPhoneNumber)
    {
        throw new NotImplementedException();
    }
}