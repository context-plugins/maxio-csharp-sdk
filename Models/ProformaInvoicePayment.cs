using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MaxioAdvancedBilling.Models;

public record ProformaInvoicePayment
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("memo")]
    [MinLength(1)]
    public string? Memo { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("original_amount")]
    [MinLength(1)]
    public string? OriginalAmount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applied_amount")]
    [MinLength(1)]
    public string? AppliedAmount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("prepayment")]
    public bool? Prepayment { get; init; }
}
