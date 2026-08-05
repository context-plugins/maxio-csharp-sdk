using System.Text.Json.Serialization;

namespace MaxioAdvancedBilling.Models;

/// <summary>
/// Allows you to pause a Subscription.
/// </summary>
public record PauseRequest
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hold")]
    public AutoResume? Hold { get; init; }
}
