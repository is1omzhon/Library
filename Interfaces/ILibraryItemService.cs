using Librarys.Commons;
namespace Librarys.Models;

public interface ILibraryItemService
{
    OperationResult AddItem(LibraryItem item);
    LibraryItem GetItemById(int id);
    LibraryItem[] GetAllItems();
    LibraryItem[] SearchItems(string titlePart);
    LibraryItem[] SearchItems(int publishedYear);
    OperationResult UpdateItem(int id, string newTitle, int newPublishedYear);
    OperationResult DeleteItem(int id);
}