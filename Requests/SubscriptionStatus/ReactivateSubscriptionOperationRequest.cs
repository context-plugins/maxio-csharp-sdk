using Maxio.Models;

namespace Maxio.Requests.SubscriptionStatus;

/// <summary>
/// The inputs of the ReactivateSubscription operation.
/// </summary>
public sealed record ReactivateSubscriptionOperationRequest
{
    /// <summary>
    /// The Chargify id of the subscription.
    /// </summary>
    public required int SubscriptionId { get; init; }

    public ReactivateSubscriptionRequest? Body { get; init; }
}
