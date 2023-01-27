using Domain.Items;
using ErrorOr;
using MediatR;

namespace Application.Items.Command.CreateItem;

public record CreateItemCommand
(
    string Name,
    string Description,
    float SellingPrice,
    float CostPrice,
    int ReorderLevel,
    int taxRatePercent,
    int LeadTime,
    List<VendorCommand> Vendors,
    List<LocationCommand> Locations,
    DateTime Created,
    DateTime Modified
) : IRequest<ErrorOr<Item>>;

public record LocationCommand
(
    string Name,
    string Description,
    int QuantityOnHand,
    string Notes

);
public record VendorCommand
(
    string Name,
    string Description,
    string Notes,
    string Phone,
    string Email,
    string Website,
    string Contracts,
    string ContactName,
    string ContactPhone,
    string ContactEmail,
    List<AddressCommand> Addresses
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