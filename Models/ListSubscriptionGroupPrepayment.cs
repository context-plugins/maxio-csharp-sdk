using System.Text.Json.Serialization;

namespace MaxioAdvancedBilling.Models;

public record ListSubscriptionGroupPrepayment
{
    [JsonPropertyName("prepayment")]
    public required ListSubscriptionGroupPrepaymentItem Prepayment { get; init; }
}
