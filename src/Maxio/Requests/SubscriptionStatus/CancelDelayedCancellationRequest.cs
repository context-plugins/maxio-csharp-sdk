namespace Maxio.Requests.SubscriptionStatus;

/// <summary>
/// The inputs of the CancelDelayedCancellation operation.
/// </summary>
public sealed record CancelDelayedCancellationRequest
{
    /// <summary>
    /// The Chargify id of the subscription.
    /// </summary>
    public required int SubscriptionId { get; init; }
}
