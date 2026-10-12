<!-- Generated file — do not edit; regenerated with the SDK. -->

# SubscriptionInvoiceAccount — operations

Accessor: `client.SubscriptionInvoiceAccount` · Source: `src/Maxio/Api/SubscriptionInvoiceAccount.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreatePrepayment

- **Auth**: `options.BasicAuth`
- **Signature**: `CreatePrepayment(CreatePrepaymentOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `CreatePrepaymentResponse`
- **Error**: `ApiException<CreatePrepaymentError>` — **Case A (typed)**
- **Error accessors**: `TryGetCreatePrepaymentErrorResponse(out CreatePrepaymentErrorResponse)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreatePrepaymentOperationRequest` | `src/Maxio/Requests/SubscriptionInvoiceAccount/CreatePrepaymentOperationRequest.cs` |
| `CreatePrepaymentRequest` | `src/Maxio/Models/CreatePrepaymentRequest.cs` |
| `CreatePrepaymentResponse` | `src/Maxio/Models/CreatePrepaymentResponse.cs` |
| `CreatePrepaymentError` | `src/Maxio/Errors/CreatePrepaymentError.cs` |
| `CreatePrepaymentErrorResponse` | `src/Maxio/Models/AnyOf/CreatePrepaymentErrorResponse.cs` |

### DeductServiceCredit

- **Auth**: `options.BasicAuth`
- **Signature**: `DeductServiceCredit(DeductServiceCreditOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeductServiceCreditError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeductServiceCreditErrorResponse(out DeductServiceCreditErrorResponse)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeductServiceCreditOperationRequest` | `src/Maxio/Requests/SubscriptionInvoiceAccount/DeductServiceCreditOperationRequest.cs` |
| `DeductServiceCreditRequest` | `src/Maxio/Models/DeductServiceCreditRequest.cs` |
| `DeductServiceCreditError` | `src/Maxio/Errors/DeductServiceCreditError.cs` |
| `DeductServiceCreditErrorResponse` | `src/Maxio/Models/AnyOf/DeductServiceCreditErrorResponse.cs` |

### IssueServiceCredit

- **Auth**: `options.BasicAuth`
- **Signature**: `IssueServiceCredit(IssueServiceCreditOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `ServiceCredit`
- **Error**: `ApiException<IssueServiceCreditError>` — **Case A (typed)**
- **Error accessors**: `TryGetIssueServiceCreditErrorResponse(out IssueServiceCreditErrorResponse)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `IssueServiceCreditOperationRequest` | `src/Maxio/Requests/SubscriptionInvoiceAccount/IssueServiceCreditOperationRequest.cs` |
| `IssueServiceCreditRequest` | `src/Maxio/Models/IssueServiceCreditRequest.cs` |
| `ServiceCredit` | `src/Maxio/Models/ServiceCredit.cs` |
| `IssueServiceCreditError` | `src/Maxio/Errors/IssueServiceCreditError.cs` |
| `IssueServiceCreditErrorResponse` | `src/Maxio/Models/AnyOf/IssueServiceCreditErrorResponse.cs` |

### ListPrepayments

- **Auth**: `options.BasicAuth`
- **Signature**: `ListPrepayments(ListPrepaymentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Query params (wire ← C#)**: `page` ← `Page`, `per_page` ← `PerPage`, `filter` ← `Filter`
- **Returns**: `PrepaymentsResponse`
- **Error**: `ApiException<ListPrepaymentsError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListPrepaymentsRequest` | `src/Maxio/Requests/SubscriptionInvoiceAccount/ListPrepaymentsRequest.cs` |
| `ListPrepaymentsFilter` | `src/Maxio/Models/ListPrepaymentsFilter.cs` |
| `PrepaymentsResponse` | `src/Maxio/Models/PrepaymentsResponse.cs` |
| `ListPrepaymentsError` | `src/Maxio/Errors/ListPrepaymentsError.cs` |

### ListServiceCredits

- **Auth**: `options.BasicAuth`
- **Signature**: `ListServiceCredits(ListServiceCreditsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Query params (wire ← C#)**: `page` ← `Page`, `per_page` ← `PerPage`, `direction` ← `Direction`
- **Returns**: `ListServiceCreditsResponse`
- **Error**: `ApiException<ListServiceCreditsError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListServiceCreditsRequest` | `src/Maxio/Requests/SubscriptionInvoiceAccount/ListServiceCreditsRequest.cs` |
| `SortingDirection` | `src/Maxio/Models/Enums/SortingDirection.cs` |
| `ListServiceCreditsResponse` | `src/Maxio/Models/ListServiceCreditsResponse.cs` |
| `ListServiceCreditsError` | `src/Maxio/Errors/ListServiceCreditsError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### ReadAccountBalances

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadAccountBalances(ReadAccountBalancesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `AccountBalances`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReadAccountBalancesRequest` | `src/Maxio/Requests/SubscriptionInvoiceAccount/ReadAccountBalancesRequest.cs` |
| `AccountBalances` | `src/Maxio/Models/AccountBalances.cs` |

### RefundPrepayment

- **Auth**: `options.BasicAuth`
- **Signature**: `RefundPrepayment(RefundPrepaymentOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `PrepaymentId`
- **Returns**: `PrepaymentResponse`
- **Error**: `ApiException<RefundPrepaymentError>` — **Case A (typed)**
- **Error accessors**: `TryGetRefundPrepaymentBaseErrorsResponse1(out RefundPrepaymentBaseErrorsResponse1)` [400] · `TryGetString(out string)` [404] · `TryGetRefundPrepaymentErrorResponse(out RefundPrepaymentErrorResponse)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RefundPrepaymentOperationRequest` | `src/Maxio/Requests/SubscriptionInvoiceAccount/RefundPrepaymentOperationRequest.cs` |
| `RefundPrepaymentRequest` | `src/Maxio/Models/RefundPrepaymentRequest.cs` |
| `PrepaymentResponse` | `src/Maxio/Models/PrepaymentResponse.cs` |
| `RefundPrepaymentError` | `src/Maxio/Errors/RefundPrepaymentError.cs` |
| `RefundPrepaymentBaseErrorsResponse1` | `src/Maxio/Models/RefundPrepaymentBaseErrorsResponse1.cs` |
| `RefundPrepaymentErrorResponse` | `src/Maxio/Models/AnyOf/RefundPrepaymentErrorResponse.cs` |

