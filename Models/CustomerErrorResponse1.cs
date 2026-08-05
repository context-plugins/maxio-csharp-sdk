using System.Text.Json.Serialization;

namespace MaxioAdvancedBilling.Models;

public record CustomerErrorResponse1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public ErrorsModel? Errors { get; init; }
}
