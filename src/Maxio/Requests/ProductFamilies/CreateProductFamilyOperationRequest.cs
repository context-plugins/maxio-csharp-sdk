using Maxio.Models;

namespace Maxio.Requests.ProductFamilies;

/// <summary>
/// The inputs of the CreateProductFamily operation.
/// </summary>
public sealed record CreateProductFamilyOperationRequest
{
    public CreateProductFamilyRequest? Body { get; init; }
}
