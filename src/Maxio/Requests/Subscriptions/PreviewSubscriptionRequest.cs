using Maxio.Models;

namespace Maxio.Requests.Subscriptions;

/// <summary>
/// The inputs of the PreviewSubscription operation.
/// </summary>
public sealed record PreviewSubscriptionRequest
{
    public CreateSubscriptionRequest? Body { get; init; }
}
