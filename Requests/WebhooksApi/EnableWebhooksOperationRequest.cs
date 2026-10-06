using Maxio.Models;

namespace Maxio.Requests.WebhooksApi;

/// <summary>
/// The inputs of the EnableWebhooks operation.
/// </summary>
public sealed record EnableWebhooksOperationRequest
{
    public EnableWebhooksRequest? Body { get; init; }
}
