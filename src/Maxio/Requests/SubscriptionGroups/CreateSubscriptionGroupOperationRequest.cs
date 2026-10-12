using Maxio.Models;

namespace Maxio.Requests.SubscriptionGroups;

/// <summary>
/// The inputs of the CreateSubscriptionGroup operation.
/// </summary>
public sealed record CreateSubscriptionGroupOperationRequest
{
    public CreateSubscriptionGroupRequest? Body { get; init; }
}
