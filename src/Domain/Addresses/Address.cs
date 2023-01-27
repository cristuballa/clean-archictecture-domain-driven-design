using Domain.Addresses.ValueObjects;
using Domain.Common.Models;

namespace Domain.Addresses.Entities;

public sealed class Address:Entity<AddressId>
{
    public string AddressLine1 { get; private set; } = default!;
    public string AddressLine2 { get; private set; } = default!;
    public string City { get; private set; } = default!;
    public string State { get; private set; } = default!;
    public string Zip { get; private set; } = default!;
    public string Country { get; private set; } = default!;
    public string Notes { get; private set; } = default!;
    private Address(AddressId addressId,
                    string addressLine1,
                    string addressLine2,
                    string city,
                    string state,
                    string zip,
                    string country,
                    string notes) : base(addressId)
    {
        AddressLine1 = addressLine1;
        AddressLine2 = addressLine2;
        City = city;
        State = state;
        Zip = zip;
        Country = country;
        Notes = notes;
    }
    public static Address Create(string addressLine1,
                                 string addressLine2,
                                 string city,
                                 string state,
                                 string zip,
                                 string country,
                                 string notes)
    {
        return new(AddressId.CreateUnique(),
                   addressLine1,
                   addressLine2,
                   city,
                   state,
                   zip,
                   country,
                   notes);
    }
    public void Update(string addressLine1,
                       string addressLine2,
                       string city,
                       string state,
                       string zip,
                       string country,
                       string notes)
    {
        AddressLine1 = addressLine1;
        AddressLine2 = addressLine2;
        City = city;
        State = state;
        Zip = zip;
        Country = country;
        Notes = notes;
    }
}