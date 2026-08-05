using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MaxioAdvancedBilling.Models;

public record VoidInvoice
{
    [JsonPropertyName("reason")]
    [MinLength(1)]
    public required string Reason { get; init; }
}
