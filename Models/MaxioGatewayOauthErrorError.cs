using System.Text.Json.Serialization;

namespace MaxioAdvancedBilling.Models;

public record MaxioGatewayOauthErrorError
{
    [JsonPropertyName("error")]
    public required string Error { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error_description")]
    public string? ErrorDescription { get; init; }
}
