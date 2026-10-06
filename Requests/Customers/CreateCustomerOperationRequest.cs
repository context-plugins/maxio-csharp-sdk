using Maxio.Models;

namespace Maxio.Requests.Customers;

/// <summary>
/// The inputs of the CreateCustomer operation.
/// </summary>
public sealed record CreateCustomerOperationRequest
{
    public CreateCustomerRequest? Body { get; init; }
}
