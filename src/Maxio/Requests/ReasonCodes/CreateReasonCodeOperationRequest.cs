using Maxio.Models;

namespace Maxio.Requests.ReasonCodes;

/// <summary>
/// The inputs of the CreateReasonCode operation.
/// </summary>
public sealed record CreateReasonCodeOperationRequest
{
    public CreateReasonCodeRequest? Body { get; init; }
}
