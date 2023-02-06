using Domain.Addresses.ValueObjects;
using Domain.Common.Models;

namespace Domain.Addresses.Entities;

public sealed class Address : Entity<AddressId>
{
    public string AddressLine1 { get; private set; } = default!;
    public string AddressLine2 { get; private set; } = default!;
    public string City { get; private set; } = default!;
    public string State { get; private set; } = default!;
    public string ZipCode { get; private set; } = default!;
    public string Country { get; private set; } = default!;
    private Address(AddressId addressId,
                    string addressLine1,
                    string addressLine2,
                    string city,
                    string state,
                    string zipCode,
                    string country) : base(addressId)
    {
        AddressLine1 = addressLine1;
        AddressLine2 = addressLine2;
        City = city;
        State = state;
        ZipCode = zipCode;
        Country = country;
    }
    public static Address Create(string addressLine1,
                                 string addressLine2,
                                 string city,
                                 string state,
                                 string zipCode,
                                 string country)
    {
        return new(AddressId.CreateUnique(),
                   addressLine1,
                   addressLine2,
                   city,
                   state,
                   zipCode,
                   country);
    }
    public void Update(string addressLine1,
                       string addressLine2,
                       string city,
                       string state,
                       string zipCode,
                       string country)
    {
        AddressLine1 = addressLine1;
        AddressLine2 = addressLine2;
        City = city;
        State = state;
        ZipCode = zipCode;
        Country = country;

    }
#pragma warning disable 8618
    private Address()
    {
    }
#pragma warning disable 8618
}