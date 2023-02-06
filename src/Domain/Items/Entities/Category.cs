using Domain.Items.ValueObjects;
using Domain.Common.Models;

namespace Domain.Items.Entities;

public sealed class Category:Entity<CategoryId>
{
    public string Name { get; private set; } = default!;
    public string Description { get; private set; } = default!;
    public string Notes { get; private set; } = default!;
    private Category(CategoryId categoryId,
                     string name,
                     string description,
                     string notes) : base(categoryId)
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
#pragma warning disable 8618
    private Category()
    {
    }
#pragma warning disable 8618
}

