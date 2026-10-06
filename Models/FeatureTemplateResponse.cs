using System.Text.Json.Serialization;
using Maxio.Core.Models;

namespace Maxio.Models;

public record FeatureTemplateResponse
{
    /// <summary>
    /// A feature that can be granted to subscribers, defined once at the site level and then attached to products or components.
    /// </summary>
    [JsonPropertyName("feature")]
    public required FeatureTemplate Feature { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
