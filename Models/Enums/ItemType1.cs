using System;
using System.Text.Json.Serialization;
using Maxio.Core.Enum;

namespace Maxio.Models.Enums;

/// <summary>
/// Item type to add. Either Product or Component.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ItemType1>))]
public sealed record ItemType1 : OpenStringEnum<ItemType1>
{
    private ItemType1(string value) : base(value)
    {
    }

    public static readonly ItemType1 Product = new("Product");

    public TResult Match<TResult>(Func<TResult> onProduct, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Product => onProduct(),
            _ => otherwise(Value)
        };

    public void Match(Action onProduct, Action<string> otherwise)
    {
        if (this == Product) onProduct();
        else otherwise(Value);
    }
}
