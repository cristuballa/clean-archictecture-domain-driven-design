namespace Contracts.Items;

public record ItemResponse
(
    string Name,
    string Description,
    float SellingPrice,
    float CostPrice,
    int ReorderLevel,
    int taxRatePercent,
    int LeadTime,
    List<VendorResponse> Vendors,
    List<LocationResponse> Locations,
    DateTime Created,
    DateTime Modified
);
public record LocationResponse
(
    string Name,
    string Description,
    int QuantityOnHand,
    string Notes

);
public record VendorResponse
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
    List<AddressResponse> Addresses
);

public record AddressResponse
(
    string AddressLine1,
    string AddressLine2,
    string City,
    string State,
    string ZipCode,
    string Country
);