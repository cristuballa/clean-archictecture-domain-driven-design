using Domain.Common.Models;

namespace Domain.Item.ValueObjects;
public sealed class ItemId:ValueObject
{
    public Guid Value { get;  }
    private ItemId(Guid value)
    {
        Value = value;
    }
    public static ItemId CreateUnique()
    {
        return new ItemId(Guid.NewGuid());
    }
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

}