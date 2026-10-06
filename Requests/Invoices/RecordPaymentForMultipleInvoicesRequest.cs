using Maxio.Models;

namespace Maxio.Requests.Invoices;

/// <summary>
/// The inputs of the RecordPaymentForMultipleInvoices operation.
/// </summary>
public sealed record RecordPaymentForMultipleInvoicesRequest
{
    public CreateMultiInvoicePaymentRequest? Body { get; init; }
}
