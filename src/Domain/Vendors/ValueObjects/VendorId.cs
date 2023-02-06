using Domain.Common.Models;

namespace Domain.Vendors.ValueObjects;
public sealed class VendorId : ValueObject
{
    public Guid Value { get; }
    private VendorId(Guid value)
    {
        Value = value;
    }
    public static VendorId Create(Guid value)
    {
        return new(value);
    }
    public static VendorId CreateUnique()
    {
        return new(Guid.NewGuid());
    }
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}