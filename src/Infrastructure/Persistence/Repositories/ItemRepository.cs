using Application.Common.Interfaces;
using Domain.Items;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly KctImsDbContext _context;

        public ItemRepository(KctImsDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(CancellationToken cancellationToken)
        {
            return await _context.Items.ToListAsync(cancellationToken);
        }

        public async Task<Item> GetItemByIdAsync(string id, CancellationToken cancellationToken)
        {
            return await _context.Items.FindAsync(id);
        }

        public async Task<Item> AddItemAsync(Item item, CancellationToken cancellationToken)
        {
            _context.Add(item);
            await _context.SaveChangesAsync(cancellationToken);
            return item;
        }

        public async Task<Item> UpdateItemAsync(Item item, CancellationToken cancellationToken)
        {
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync(cancellationToken);
            return item;
        }

        public async Task<Item> DeleteItemAsync(Item item, CancellationToken cancellationToken)
        {
            _context.Items.Remove(item);
            await _context.SaveChangesAsync(cancellationToken);
            return item;
        }

        // public async Task<bool> ItemExistsAsync(string id, CancellationToken cancellationToken)
        // {
        //     return await _context.Items.AnyAsync(x => x.Id == id, cancellationToken);
        // }
    }
}