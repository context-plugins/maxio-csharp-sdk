using Maxio.Models;
using Maxio.Models.Enums;

namespace Maxio.Requests.CustomFields;

/// <summary>
/// The inputs of the UpdateMetafield operation.
/// </summary>
public sealed record UpdateMetafieldRequest
{
    /// <summary>
    /// The resource type to which the metafields belong.
    /// </summary>
    public required ResourceType ResourceType { get; init; }

    public UpdateMetafieldsRequest? Body { get; init; }
}
