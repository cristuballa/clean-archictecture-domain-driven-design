namespace Contracts.Items;

public record ItemResponse
(
    string Description,
    float SellingPrice,
    float CostPrice,
    string CostCode,
    int ReorderLevel,
    int ReorderQuantity,
    int TaxRatePercent,
    int LeadTime,
    List<VendorRequest> Vendors,
    List<LocationRequest> Locations,
    DateTime Created,
    DateTime Modified
);
public record LocationResponse
(
    string Name,
    int QuantityOnHand,
    string Notes

);
public record VendorResponse
(
    string Name,
    List<AddressRequest> Addresses,
    string Phone,
    string Fax,
    string Email,
    string Website,
    string Contact,
    string ContactName,
    string ContactPhone,
    string ContactEmail
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