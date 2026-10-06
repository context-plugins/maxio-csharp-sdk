using Maxio.Models;

namespace Maxio.Requests.Subscriptions;

/// <summary>
/// The inputs of the CreateSubscription operation.
/// </summary>
public sealed record CreateSubscriptionOperationRequest
{
    public CreateSubscriptionRequest? Body { get; init; }
}
