using Maxio.Models;

namespace Maxio.Requests.Invoices;

/// <summary>
/// The inputs of the RecordPaymentForSubscription operation.
/// </summary>
public sealed record RecordPaymentForSubscriptionRequest
{
    /// <summary>
    /// The Chargify id of the subscription.
    /// </summary>
    public required int SubscriptionId { get; init; }

    public RecordPaymentRequest? Body { get; init; }
}
