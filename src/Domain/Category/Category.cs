using Domain.Category.ValueObjects;
using Domain.Common.Models;

namespace Domain.Category;

public sealed class Category:Entity<CategoryId>
{
    public string Name { get; private set; } = default!;
    public string Description { get; private set; } = default!;
    public string Notes { get; private set; } = default!;
    private Category(CategoryId id, string name, string description, string notes) : base(id)
    {
        Name = name;
        Description = description;
        Notes = notes;
    }
    public static Category Create(string name, string description, string notes)
    {
        return new(CategoryId.CreateUnique(), name, description, notes);
    }
    public void Update(string name, string description, string notes)
    {
        Name = name;
        Description = description;
        Notes = notes;
    }
}

