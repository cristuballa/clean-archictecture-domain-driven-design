using Domain.Common.Models;
using Domain.Items.ValueObjects;
using Domain.Items.Entities;
using Domain.Vendors;

namespace Domain.Items;

public sealed class Item : AggregateRoot<ItemId>
{
    private readonly List<Vendor> _vendors = new();
    private readonly List<Location> _locations = new();
    public string Description { get; }
    public float QuantityOnHand { get; }
    public float SellingPrice { get; }
    public float CostPrice { get; }
    public string CostCode { get; }
    public CategoryId CategoryId { get; }
    public Enum UnitOfMeasureId { get;  }
    public int ReorderLevel { get;  }
    public int ReorderQuantity { get; }
    public int TaxRatePercent { get;  }
    public int LeadTime { get; }
    public DateTime Created { get; }
    public DateTime Modified { get; }
    public IReadOnlyList<Vendor> Vendors => _vendors.AsReadOnly();
    public IReadOnlyList<Location> Locations => _locations.AsReadOnly();
    private Item(ItemId itemId,
                 string description,
                 float quantityOnHand,
                 float sellingPrice,
                 float costPrice,
                 string costCode,
                 CategoryId categoryId,
                 Enum unitOfMeasureId,
                 int reorderLevel,
                 int reorderQuantity,
                 int taxRatePercent,
                 int leadTime,
                 DateTime created,
                 DateTime modified) : base(itemId)
    {
        Description = description;
        QuantityOnHand = quantityOnHand;
        SellingPrice = sellingPrice;
        CostPrice = costPrice;
        CostCode = costCode;
        CategoryId = categoryId;
        UnitOfMeasureId = unitOfMeasureId;
        ReorderLevel = reorderLevel;
        ReorderQuantity = reorderQuantity;
        TaxRatePercent = taxRatePercent;
        LeadTime = leadTime;
        Created = created;
        Modified = modified;
    }
    public static Item Create(string description,
                              float quantityOnHand,
                              float sellingPrice,
                              float costPrice,
                              string costCode,
                              CategoryId categoryId,
                              Enum unitOfMeasureId,
                              int reorderLevel,
                              int reorderQuantity,
                              int taxRatePercent,
                              int leadTime,
                              DateTime created,
                              DateTime modified)
    {
        return new(ItemId.CreateUnique(),
                   description,
                   quantityOnHand,
                   sellingPrice,
                   costPrice,
                   costCode,
                   categoryId,
                   unitOfMeasureId,
                   reorderLevel,
                   reorderQuantity,
                   taxRatePercent,
                   leadTime,
                   created,
                   modified);
    }
}