using Maxio.Models;

namespace Maxio.Requests.SubscriptionGroups;

/// <summary>
/// The inputs of the SignupWithSubscriptionGroup operation.
/// </summary>
public sealed record SignupWithSubscriptionGroupRequest
{
    public SubscriptionGroupSignupRequest? Body { get; init; }
}
