using Domain.Common.Models;
using Domain.Item.ValueObjects;
namespace Domain.Item;

public sealed class Item : AggregateRoot<ItemId>
{
    public required string Description { get; set; }
    public float QuantityOnHand { get; set; }
    public float SellingPrice { get; set; }
    public float CostPrice { get; set; }
    public string CostCode { get; set; } = default!;
    public Guid CategoryId { get; set; }
    public Guid UnitOfMeasure { get; set; }
    public int ReorderLevel { get; set; }
    public int ReorderQuantity { get; set; }
    public int TaxRatePercent { get; set; }
    public Guid Vendors { get; set; }
    public Guid Manufacturer { get; set; }
    public int LeadTime { get; set; }

    private Item(ItemId itemId) : base(itemId)
    {

    }
    public static Item Create(string description,
                              float quantityOnHand,
                              float sellingPrice,
                              float costPrice,
                              string costCode,
                              Guid categoryId,
                              Guid unitOfMeasure,
                              int reorderLevel,
                              int reorderQuantity,
                              int taxRatePercent,
                              Guid vendors,
                              Guid manufacturer,
                              int leadTime)
    {
        return new (ItemId.CreateUnique(),
                    description,
                    quantityOnHand,
                    sellingPrice,
                    costPrice,
                    costCode,
                    categoryId,
                    unitOfMeasure,
                    reorderLevel,
                    reorderQuantity,
                    taxRatePercent,
                    vendors,
                    manufacturer,
                    leadTime);
    }

    
}

public record Manufacturer(Guid Id,
                           string Name,
                           string Address,
                           string City,
                           string State,
                           string ZipCode,
                           string Country,
                           string Phone,
                           string Fax,
                           string Email,
                           string Website,
                           string ContactName,
                           string ContactPhone,
                           string ContactEmail,
                           string Notes);
public record Vendor(Guid Id,
                     string Name,
                     string Address,
                     string City,
                     string State,
                     string ZipCode,
                     string Country,
                     string Phone,
                     string Fax,
                     string Email,
                     string Website,
                     string ContactName,
                     string ContactPhone,
                     string ContactEmail,
                     string Notes);
public record Category(Guid Id,
                       string Name,
                       string Description,
                       string Notes);
public record UnitOfMeasure(Guid Id,
                            string Name,
                            string Description,
                            string Notes);

public class Location
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public string Address { get; set; } = default!;
    public string Notes { get; set; } = default!;
}

public record SalesOrder(Guid Id,
                         string OrderNumber,
                         DateTime OrderDate,
                         DateTime? RequiredDate,
                         DateTime? ShippedDate,
                         string Status,
                         string Notes,
                         Guid CustomerId,
                         Guid SalesPersonId,
                         Guid ShipperId,
                         Guid LocationId,
                         Guid PaymentMethodId,
                         Guid CurrencyId,
                         Guid TaxRateId,
                         Guid DiscountId,
                         Guid SalesOrderDetails);

public record SalesOrderDetail(Guid Id,
                               Guid SalesOrderId,
                               Guid ItemId,
                               float Quantity,
                               float UnitPrice,
                               string CurrencyId,
                               float Discount,
                               float Tax,
                               float Total);

public record Currency(Guid Id,
                        string Name,
                        string Symbol,
                        string Notes);

