using System.Text.Json.Serialization;

namespace Contracts.Items;

public record ItemRequest
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
public record LocationRequest
(
    string Name,
    int QuantityOnHand,
    string Notes

);
public record VendorRequest
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

public record AddressRequest
(
    string AddressLine1,
    string AddressLine2,
    string City,
    string State,
    string ZipCode,
    string Country
);