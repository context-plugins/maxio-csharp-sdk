using Maxio.Models;

namespace Maxio.Requests.FeatureTemplates;

/// <summary>
/// The inputs of the CreateFeatureTemplate operation.
/// </summary>
public sealed record CreateFeatureTemplateOperationRequest
{
    public CreateFeatureTemplateRequest? Body { get; init; }
}
