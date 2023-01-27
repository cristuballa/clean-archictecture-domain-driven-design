
using Domain.Common.Models;
using Domain.Items.ValueObjects;

namespace Domain.Items.Entities;
public sealed class Location:Entity<LocationId>
{    public string Name { get; private set; } = default!;
    public float QuantityOnHand { get; private set; }
    public string Notes { get; private set; }

    private Location(LocationId locationId,
                     string name,
                     float quantityOnHand,
                     string notes) : base(locationId)
    {
        Name = name;
        QuantityOnHand = quantityOnHand;
        Notes = notes;
    }
    public static Location Create(string name, float quantityOnHand, string notes)
    {
        return new(LocationId.CreateUnique(), name, quantityOnHand, notes);
    }

}