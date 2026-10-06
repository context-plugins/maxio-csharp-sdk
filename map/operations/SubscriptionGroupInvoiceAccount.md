<!-- Generated file — do not edit; regenerated with the SDK. -->

# SubscriptionGroupInvoiceAccount — operations

Accessor: `client.SubscriptionGroupInvoiceAccount` · Source: `Api/SubscriptionGroupInvoiceAccount.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateSubscriptionGroupPrepayment

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateSubscriptionGroupPrepayment(CreateSubscriptionGroupPrepaymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Uid`
- **Returns**: `SubscriptionGroupPrepaymentResponse`
- **Error**: `ApiException<CreateSubscriptionGroupPrepaymentError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateSubscriptionGroupPrepaymentRequest` | `Requests/SubscriptionGroupInvoiceAccount/CreateSubscriptionGroupPrepaymentRequest.cs` |
| `SubscriptionGroupPrepaymentRequest` | `Models/SubscriptionGroupPrepaymentRequest.cs` |
| `SubscriptionGroupPrepaymentResponse` | `Models/SubscriptionGroupPrepaymentResponse.cs` |
| `CreateSubscriptionGroupPrepaymentError` | `Errors/CreateSubscriptionGroupPrepaymentError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### DeductSubscriptionGroupServiceCredit

- **Auth**: `options.BasicAuth`
- **Signature**: `DeductSubscriptionGroupServiceCredit(DeductSubscriptionGroupServiceCreditRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Uid`
- **Returns**: `ServiceCredit`
- **Error**: `ApiException<DeductSubscriptionGroupServiceCreditError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeductSubscriptionGroupServiceCreditRequest` | `Requests/SubscriptionGroupInvoiceAccount/DeductSubscriptionGroupServiceCreditRequest.cs` |
| `DeductServiceCreditRequest` | `Models/DeductServiceCreditRequest.cs` |
| `ServiceCredit` | `Models/ServiceCredit.cs` |
| `DeductSubscriptionGroupServiceCreditError` | `Errors/DeductSubscriptionGroupServiceCreditError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### IssueSubscriptionGroupServiceCredit

- **Auth**: `options.BasicAuth`
- **Signature**: `IssueSubscriptionGroupServiceCredit(IssueSubscriptionGroupServiceCreditRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Uid`
- **Returns**: `ServiceCreditResponse`
- **Error**: `ApiException<IssueSubscriptionGroupServiceCreditError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `IssueSubscriptionGroupServiceCreditRequest` | `Requests/SubscriptionGroupInvoiceAccount/IssueSubscriptionGroupServiceCreditRequest.cs` |
| `IssueServiceCreditRequest` | `Models/IssueServiceCreditRequest.cs` |
| `ServiceCreditResponse` | `Models/ServiceCreditResponse.cs` |
| `IssueSubscriptionGroupServiceCreditError` | `Errors/IssueSubscriptionGroupServiceCreditError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### ListPrepaymentsForSubscriptionGroup

- **Auth**: `options.BasicAuth`
- **Signature**: `ListPrepaymentsForSubscriptionGroup(ListPrepaymentsForSubscriptionGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Uid`
- **Query params (wire ← C#)**: `page` ← `Page`, `per_page` ← `PerPage`, `filter` ← `Filter`
- **Returns**: `ListSubscriptionGroupPrepaymentResponse`
- **Error**: `ApiException<ListPrepaymentsForSubscriptionGroupError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListPrepaymentsForSubscriptionGroupRequest` | `Requests/SubscriptionGroupInvoiceAccount/ListPrepaymentsForSubscriptionGroupRequest.cs` |
| `ListPrepaymentsFilter` | `Models/ListPrepaymentsFilter.cs` |
| `ListSubscriptionGroupPrepaymentResponse` | `Models/ListSubscriptionGroupPrepaymentResponse.cs` |
| `ListPrepaymentsForSubscriptionGroupError` | `Errors/ListPrepaymentsForSubscriptionGroupError.cs` |

