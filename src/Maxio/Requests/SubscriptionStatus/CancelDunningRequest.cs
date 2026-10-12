namespace Maxio.Requests.SubscriptionStatus;

/// <summary>
/// The inputs of the CancelDunning operation.
/// </summary>
public sealed record CancelDunningRequest
{
    /// <summary>
    /// The Chargify id of the subscription.
    /// </summary>
    public required int SubscriptionId { get; init; }
}
