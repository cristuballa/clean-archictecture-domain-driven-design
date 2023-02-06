using Domain.Common.Models;
using Domain.Items.ValueObjects;
using Domain.Items.Entities;
using Domain.Vendors;

namespace Domain.Items;

public sealed class Item : AggregateRoot<ItemId>
{
    private readonly List<Vendor> _vendors = new();
    private readonly List<Location> _locations = new();
    public string Description { get; private set; } = default!;
    public float QuantityOnHand { get; private set; } = default!;
    public float SellingPrice { get; private set; } = default!;
    public float CostPrice { get; private set; } = default!;
    public string CostCode { get; private set; } = default!;
    public int ReorderLevel { get; private set; } = default!;
    public int ReorderQuantity { get; private set; } = default!;
    public int TaxRatePercent { get; private set; } = default!;
    public int LeadTime { get; private set; } = default!;
    public DateTime Created { get; private set; } = default!;
    public DateTime Modified { get; private set; } = default!;
    public IReadOnlyList<Vendor> Vendors => _vendors.AsReadOnly();
    public IReadOnlyList<Location> Locations => _locations.AsReadOnly();

#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
    private Item()
    { }
#pragma warning restore CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
    private Item(ItemId itemId,
                 string description,
                 float sellingPrice,
                 float costPrice,
                 string costCode,
                 int reorderLevel,
                 int reorderQuantity,
                 int taxRatePercent,
                 int leadTime,
                 DateTime created,
                 DateTime modified,
                 IList<Vendor> vendors,
                 IList<Location> locations) : base(itemId)
    {
        Description = description;
        SellingPrice = sellingPrice;
        CostPrice = costPrice;
        CostCode = costCode;
        ReorderLevel = reorderLevel;
        ReorderQuantity = reorderQuantity;
        TaxRatePercent = taxRatePercent;
        LeadTime = leadTime;
        Created = created;
        Modified = modified;
        _vendors.AddRange(vendors);
        _locations.AddRange(locations);
    }
    public static Item Create(string description,
                              float sellingPrice,
                              float costPrice,
                              string costCode,
                              int reorderLevel,
                              int reorderQuantity,
                              int taxRatePercent,
                              int leadTime,
                              DateTime created,
                              DateTime modified,
                              IList<Vendor> vendors,
                              IList<Location> locations)
    {
        return new(ItemId.CreateUnique(),
                   description,
                   sellingPrice,
                   costPrice,
                   costCode,
                   reorderLevel,
                   reorderQuantity,
                   taxRatePercent,
                   leadTime,
                   created,
                   modified,
                   vendors,
                   locations);
    }
}