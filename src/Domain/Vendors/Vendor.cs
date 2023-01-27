using Domain.Addresses.Entities;
using Domain.Common.Models;
using Domain.Vendors.ValueObjects;

namespace Domain.Vendors;
public sealed class Vendor:Entity<VendorId>
{
    private readonly List<Address> _address = new();
    public string Name { get; private set; } = default!;
    public string Description { get; private set; } = default!;
    public string Notes { get; private set; } = default!;
    public string Phone { get; private set; } = default!;
    public string Email { get; private set; } = default!;
    public string Website { get; private set; } = default!;
    public string Contracts { get; private set; } = default!;
    public string ContactName { get; private set; } = default!;
    public string ContactPhone { get; private set; } = default!;
    public string ContactEmail { get; private set; } = default!;
    public  IReadOnlyList<Address> Addresses => _address.AsReadOnly();
    
    private Vendor(VendorId vendorId,
                   string name,
                   string description,
                   string notes,
                   string phone,
                   string email,
                   string website,
                   string contracts,
                   string contactName,
                   string contactPhone,
                   string contactEmail) : base(vendorId)
    {
        Name = name;
        Description = description;
        Notes = notes;
        Phone = phone;
        Email = email;
        Website = website;
        Contracts = contracts;
        ContactName = contactName;
        ContactPhone = contactPhone;
        ContactEmail = contactEmail;
    }
   
}