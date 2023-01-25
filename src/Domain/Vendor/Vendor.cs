using Domain.Common.Models;
using Domain.Vendor.ValueObjects;

namespace Domain.Vendor;
public sealed class Vendor:AggregateRoot<VendorId>
{
    public string Name { get; private set; } = default!;
    public string Description { get; private set; } = default!;
    public string Notes { get; private set; } = default!;
    private Vendor(VendorId id, string name, string description, string notes) : base(id)
    {
        Name = name;
        Description = description;
        Notes = notes;
    }
    public static Vendor Create(string name, string description, string notes)
    {
        return new(VendorId.CreateUnique(), name, description, notes);
    }
    public void Update(string name, string description, string notes)
    {
        Name = name;
        Description = description;
        Notes = notes;
    }
}