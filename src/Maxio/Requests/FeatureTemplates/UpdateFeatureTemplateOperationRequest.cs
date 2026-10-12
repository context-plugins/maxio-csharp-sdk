using Maxio.Models;

namespace Maxio.Requests.FeatureTemplates;

/// <summary>
/// The inputs of the UpdateFeatureTemplate operation.
/// </summary>
public sealed record UpdateFeatureTemplateOperationRequest
{
    /// <summary>
    /// The Advanced Billing id of the feature template.
    /// </summary>
    public required int Id { get; init; }

    public UpdateFeatureTemplateRequest? Body { get; init; }
}
