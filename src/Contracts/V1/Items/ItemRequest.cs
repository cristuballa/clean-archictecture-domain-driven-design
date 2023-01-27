namespace Contracts.Items;

public record ItemRequest
(
    string Name,
    string Description,
    float SellingPrice,
    float CostPrice,
    int ReorderLevel,
    int taxRatePercent,
    int LeadTime,
    List<VendorRequest> Vendors,
    List<LocationRequest> Locations,
    DateTime Created,
    DateTime Modified
);
public record LocationRequest
(
    string Name,
    string Description,
    int QuantityOnHand,
    string Notes

);
public record VendorRequest
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
    List<AddressRequest> Addresses
);

public record AddressRequest
(
    string AddressLine1,
    string AddressLine2,
    string City,
    string State,
    string ZipCode,
    string Country
);