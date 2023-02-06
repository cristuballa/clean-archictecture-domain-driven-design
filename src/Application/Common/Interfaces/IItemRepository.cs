using Domain.Items;

namespace Application.Common.Interfaces;

public interface IItemRepository
{
    Task<Item> AddItemAsync(Item item, CancellationToken cancellationToken);
    Task<Item> DeleteItemAsync(Item item, CancellationToken cancellationToken);
    Task<Item> GetItemByIdAsync(string id, CancellationToken cancellationToken);
    Task<IEnumerable<Item>> GetItemsAsync(CancellationToken cancellationToken);
    Task<Item> UpdateItemAsync(Item item, CancellationToken cancellationToken);
}