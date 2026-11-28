using LibraryItem.Models;
using Librarys.Commons;

public interface IMemberService
{
    OperationResult RegisterMember(Member member);
    Member GetMemberById(int id);
    Member[] GetAllMembers();
    OperationResult UpdateMember(int id, string newFullName, string newPhoneNumber);
    OperationResult DeleteMember(int id);
}