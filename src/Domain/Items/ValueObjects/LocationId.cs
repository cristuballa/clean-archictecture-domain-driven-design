using Domain.Common.Models;

namespace Domain.Items.ValueObjects;
public sealed class LocationId:ValueObject
{
    public Guid Value { get;  }
    private LocationId(Guid value)
    {
        Value = value;
    }
    public static LocationId CreateUnique()
    {
        return new(Guid.NewGuid());
    }
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}