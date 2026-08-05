using System.Text.Json.Serialization;

namespace MaxioAdvancedBilling.Models;

public record MaxioGatewayOauthTokenRequest
{
    [JsonPropertyName("grant_type")]
    public string GrantType { get; } = "client_credentials";

    /// <summary>
    /// OAuth client identifier. Omit when authenticating with HTTP Basic.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>
    /// OAuth client secret. Omit when authenticating with HTTP Basic.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_secret")]
    public string? ClientSecret { get; init; }
}
