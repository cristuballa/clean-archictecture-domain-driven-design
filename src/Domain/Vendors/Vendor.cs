using Domain.Addresses.Entities;
using Domain.Common.Models;
using Domain.Vendors.ValueObjects;

namespace Domain.Vendors;
public sealed class Vendor : Entity<VendorId>
{
    private readonly List<Address> _address = new();
    public string Name { get; private set;} = default!;
    public string Fax { get; private set;} = default!;
    public string Phone { get; private set;} = default!;
    public string Email { get; private set; } = default!;
    public string Website { get; private set;} = default!;
    public string Contact { get; private set;} = default!;
    public string ContactName { get; private set;} = default!;
    public string ContactPhone { get; private set; } = default!;
    public string ContactEmail { get; private set;} = default!;
    public IReadOnlyList<Address> Addresses => _address.AsReadOnly();

    private Vendor(VendorId vendorId,
                   string name,
                   string fax,
                   string phone,
                   string email,
                   string website,
                   string contact,
                   string contactName,
                   string contactPhone,
                   string contactEmail,
                   IList<Address> addresses) : base(vendorId)
    {
        Name = name;
        Fax = fax;
        Phone = phone;
        Email = email;
        Website = website;
        Contact = contact;
        ContactName = contactName;
        ContactPhone = contactPhone;
        ContactEmail = contactEmail;
        _address.AddRange(addresses);
    }
    public static Vendor Create(string name,
                                string fax,
                                string phone,
                                string email,
                                string website,
                                string contact,
                                string contactName,
                                string contactPhone,
                                string contactEmail,
                                List<Address> addresses
                              )
    {
        return new(VendorId.CreateUnique(),
                   name,
                   fax,
                   phone,
                   email,
                   website,
                   contact,
                   contactName,
                   contactPhone,
                   contactEmail, addresses);
    }
#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
    private Vendor()
    {
    }
#pragma warning restore CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
}