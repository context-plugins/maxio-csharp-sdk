<!-- Generated file — do not edit; regenerated with the SDK. -->

# AdvanceInvoice — operations

Accessor: `client.AdvanceInvoice` · Source: `src/Maxio/Api/AdvanceInvoice.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### IssueAdvanceInvoice

- **Auth**: `options.BasicAuth`
- **Signature**: `IssueAdvanceInvoice(IssueAdvanceInvoiceOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `Invoice`
- **Error**: `ApiException<IssueAdvanceInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `IssueAdvanceInvoiceOperationRequest` | `src/Maxio/Requests/AdvanceInvoice/IssueAdvanceInvoiceOperationRequest.cs` |
| `IssueAdvanceInvoiceRequest` | `src/Maxio/Models/IssueAdvanceInvoiceRequest.cs` |
| `Invoice` | `src/Maxio/Models/Invoice.cs` |
| `IssueAdvanceInvoiceError` | `src/Maxio/Errors/IssueAdvanceInvoiceError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### ReadAdvanceInvoice

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadAdvanceInvoice(ReadAdvanceInvoiceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `Invoice`
- **Error**: `ApiException<ReadAdvanceInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ReadAdvanceInvoiceRequest` | `src/Maxio/Requests/AdvanceInvoice/ReadAdvanceInvoiceRequest.cs` |
| `Invoice` | `src/Maxio/Models/Invoice.cs` |
| `ReadAdvanceInvoiceError` | `src/Maxio/Errors/ReadAdvanceInvoiceError.cs` |

### VoidAdvanceInvoice

- **Auth**: `options.BasicAuth`
- **Signature**: `VoidAdvanceInvoice(VoidAdvanceInvoiceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `Invoice`
- **Error**: `ApiException<VoidAdvanceInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VoidAdvanceInvoiceRequest` | `src/Maxio/Requests/AdvanceInvoice/VoidAdvanceInvoiceRequest.cs` |
| `VoidInvoiceRequest` | `src/Maxio/Models/VoidInvoiceRequest.cs` |
| `Invoice` | `src/Maxio/Models/Invoice.cs` |
| `VoidAdvanceInvoiceError` | `src/Maxio/Errors/VoidAdvanceInvoiceError.cs` |

