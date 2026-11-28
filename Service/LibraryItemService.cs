using Librarys.Commons;

namespace Librarys.Models;

public class LibraryItemServise : ILibraryItemService
{
    private readonly Dictionary<int, LibraryItem> _items = new();
    private bool IsSuccess;

    public OperationResult AddItem(LibraryItem item)
    {
        if (item == null || _items.ContainsKey(item.Id)) //muvaffaqiyatsiz natija qaytaradi.
        {}
        return null;
    }

    public OperationResult DeleteItem(int id)
    {
        // if (_items)
        {
            throw new NotImplementedException();
        }
    }

    public LibraryItem[] GetAllItems()
    {
        throw new NotImplementedException();
    }

    public LibraryItem GetItemById(int id)
    {
        if (true)
        {
            throw new NotImplementedException();
        }
    }

    public LibraryItem[] SearchItems(string titlePart)
    {
        throw new NotImplementedException();
    }

    public LibraryItem[] SearchItems(int publishedYear)
    {
        throw new NotImplementedException();
    }

    public OperationResult UpdateItem(int id, string newTitle, int newPublishedYear)
    {
        throw new NotImplementedException();
    }
}
