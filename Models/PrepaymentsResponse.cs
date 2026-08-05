using System.Collections.Generic;
using System.Text.Json.Serialization;
using MaxioAdvancedBilling.Core.Validation.Attributes;

namespace MaxioAdvancedBilling.Models;

public record PrepaymentsResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("prepayments")]
    [UniqueItems]
    public IReadOnlyList<Prepayment>? Prepayments { get; init; }
}
