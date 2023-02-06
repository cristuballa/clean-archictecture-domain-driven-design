using Domain.Items;
using ErrorOr;
using MediatR;

namespace Application.Items.Command.CreateItem;

public record CreateItemCommand
(
    string Description,
    float SellingPrice,
    float CostPrice,
    string CostCode,
    int ReorderLevel,
    int ReorderQuantity,
    int TaxRatePercent,
    int LeadTime,
    List<VendorCommand> Vendors,
    List<LocationCommand> Locations,
    DateTime Created,
    DateTime Modified
) : IRequest<ErrorOr<Item>>;

public record LocationCommand
(
    string Name,
    int QuantityOnHand,
    string Notes

);
public record VendorCommand
(
   string Name,
    List<AddressCommand> Addresses,
    string Phone,
    string Fax,
    string Email,
    string Website,
    string Contact,
    string ContactName,
    string ContactPhone,
    string ContactEmail
);

public record AddressCommand
(
    string AddressLine1,
    string AddressLine2,
    string City,
    string State,
    string ZipCode,
    string Country
);