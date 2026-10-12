using System.Collections.Generic;
using Maxio.Models.Enums;

namespace Maxio.Requests.SubscriptionGroups;

/// <summary>
/// The inputs of the ReadSubscriptionGroup operation.
/// </summary>
public sealed record ReadSubscriptionGroupRequest
{
    /// <summary>
    /// The uid of the subscription group
    /// </summary>
    public required string Uid { get; init; }

    /// <summary>
    /// Allows including additional data in the response. Use in query: <c>include[]=current_billing_amount_in_cents</c>.
    /// </summary>
    public IReadOnlyList<SubscriptionGroupInclude>? Include { get; init; }
}
