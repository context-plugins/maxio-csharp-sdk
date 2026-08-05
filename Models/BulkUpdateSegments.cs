using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MaxioAdvancedBilling.Models;

public record BulkUpdateSegments
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("segments")]
    [MaxLength(1000)]
    public IReadOnlyList<BulkUpdateSegmentsItem>? Segments { get; init; }
}
