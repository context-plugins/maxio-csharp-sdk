using System;
using System.Text.Json.Serialization;
using Maxio.Core.Enum;

namespace Maxio.Models.Enums;

/// <summary>
/// Item type to add. Either Product or Component.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ItemType>))]
public sealed record ItemType : OpenStringEnum<ItemType>
{
    private ItemType(string value) : base(value)
    {
    }

    public static readonly ItemType Component = new("Component");

    public TResult Match<TResult>(Func<TResult> onComponent, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Component => onComponent(),
            _ => otherwise(Value)
        };

    public void Match(Action onComponent, Action<string> otherwise)
    {
        if (this == Component) onComponent();
        else otherwise(Value);
    }
}
