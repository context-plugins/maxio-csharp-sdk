using Maxio.Models;

namespace Maxio.Requests.SubscriptionRenewals;

/// <summary>
/// The inputs of the UpdateScheduledRenewalConfiguration operation.
/// </summary>
public sealed record UpdateScheduledRenewalConfigurationRequest
{
    /// <summary>
    /// The Chargify id of the subscription.
    /// </summary>
    public required int SubscriptionId { get; init; }

    /// <summary>
    /// The renewal id.
    /// </summary>
    public required int Id { get; init; }

    public ScheduledRenewalConfigurationRequest? Body { get; init; }
}
