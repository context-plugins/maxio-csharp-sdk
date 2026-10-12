using Maxio.Models;

namespace Maxio.Requests.PaymentProfiles;

/// <summary>
/// The inputs of the VerifyBankAccount operation.
/// </summary>
public sealed record VerifyBankAccountRequest
{
    /// <summary>
    /// Identifier of the bank account in the system.
    /// </summary>
    public required int BankAccountId { get; init; }

    public BankAccountVerificationRequest? Body { get; init; }
}
