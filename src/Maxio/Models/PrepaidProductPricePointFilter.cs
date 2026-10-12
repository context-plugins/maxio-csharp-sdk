using System.Text.Json.Serialization;
using Maxio.Core.Models;

namespace Maxio.Models;

public record PrepaidProductPricePointFilter
{
    /// <summary>
    /// Passed as a parameter to list methods to return only non null values.
    /// </summary>
    [JsonPropertyName("product_price_point_id")]
    public string ProductPricePointId { get; } = "not_null";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
