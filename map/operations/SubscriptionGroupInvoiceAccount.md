<!-- Generated file — do not edit; regenerated with the SDK. -->

# SubscriptionGroupInvoiceAccount — operations

Accessor: `client.SubscriptionGroupInvoiceAccount` · Source: `src/Maxio/Api/SubscriptionGroupInvoiceAccount.cs` · 4 operations

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
| `CreateSubscriptionGroupPrepaymentRequest` | `src/Maxio/Requests/SubscriptionGroupInvoiceAccount/CreateSubscriptionGroupPrepaymentRequest.cs` |
| `SubscriptionGroupPrepaymentRequest` | `src/Maxio/Models/SubscriptionGroupPrepaymentRequest.cs` |
| `SubscriptionGroupPrepaymentResponse` | `src/Maxio/Models/SubscriptionGroupPrepaymentResponse.cs` |
| `CreateSubscriptionGroupPrepaymentError` | `src/Maxio/Errors/CreateSubscriptionGroupPrepaymentError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### DeductSubscriptionGroupServiceCredit

- **Auth**: `options.BasicAuth`
- **Signature**: `DeductSubscriptionGroupServiceCredit(DeductSubscriptionGroupServiceCreditRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Uid`
- **Returns**: `ServiceCredit`
- **Error**: `ApiException<DeductSubscriptionGroupServiceCreditError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeductSubscriptionGroupServiceCreditRequest` | `src/Maxio/Requests/SubscriptionGroupInvoiceAccount/DeductSubscriptionGroupServiceCreditRequest.cs` |
| `DeductServiceCreditRequest` | `src/Maxio/Models/DeductServiceCreditRequest.cs` |
| `ServiceCredit` | `src/Maxio/Models/ServiceCredit.cs` |
| `DeductSubscriptionGroupServiceCreditError` | `src/Maxio/Errors/DeductSubscriptionGroupServiceCreditError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### IssueSubscriptionGroupServiceCredit

- **Auth**: `options.BasicAuth`
- **Signature**: `IssueSubscriptionGroupServiceCredit(IssueSubscriptionGroupServiceCreditRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Uid`
- **Returns**: `ServiceCreditResponse`
- **Error**: `ApiException<IssueSubscriptionGroupServiceCreditError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `IssueSubscriptionGroupServiceCreditRequest` | `src/Maxio/Requests/SubscriptionGroupInvoiceAccount/IssueSubscriptionGroupServiceCreditRequest.cs` |
| `IssueServiceCreditRequest` | `src/Maxio/Models/IssueServiceCreditRequest.cs` |
| `ServiceCreditResponse` | `src/Maxio/Models/ServiceCreditResponse.cs` |
| `IssueSubscriptionGroupServiceCreditError` | `src/Maxio/Errors/IssueSubscriptionGroupServiceCreditError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

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
| `ListPrepaymentsForSubscriptionGroupRequest` | `src/Maxio/Requests/SubscriptionGroupInvoiceAccount/ListPrepaymentsForSubscriptionGroupRequest.cs` |
| `ListPrepaymentsFilter` | `src/Maxio/Models/ListPrepaymentsFilter.cs` |
| `ListSubscriptionGroupPrepaymentResponse` | `src/Maxio/Models/ListSubscriptionGroupPrepaymentResponse.cs` |
| `ListPrepaymentsForSubscriptionGroupError` | `src/Maxio/Errors/ListPrepaymentsForSubscriptionGroupError.cs` |

