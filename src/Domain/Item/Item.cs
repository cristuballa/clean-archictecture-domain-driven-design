using Domain.Category.ValueObjects;
using Domain.Common.Models;
using Domain.Item.ValueObjects;
using Domain.Vendor;
namespace Domain.Item;

public sealed class Item : AggregateRoot<ItemId>
{
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
    
    private Item(ItemId ItemId,
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
                 DateTime modified) : base(ItemId)
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