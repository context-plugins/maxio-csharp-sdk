using Maxio.Models;

namespace Maxio.Requests.SubscriptionStatus;

/// <summary>
/// The inputs of the CancelSubscription operation.
/// </summary>
public sealed record CancelSubscriptionRequest
{
    /// <summary>
    /// The Chargify id of the subscription.
    /// </summary>
    public required int SubscriptionId { get; init; }

    public CancellationRequest? Body { get; init; }
}
