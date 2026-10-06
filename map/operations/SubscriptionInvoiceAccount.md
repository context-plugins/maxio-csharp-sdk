<!-- Generated file — do not edit; regenerated with the SDK. -->

# SubscriptionInvoiceAccount — operations

Accessor: `client.SubscriptionInvoiceAccount` · Source: `Api/SubscriptionInvoiceAccount.cs` · 7 operations

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
| `CreatePrepaymentOperationRequest` | `Requests/SubscriptionInvoiceAccount/CreatePrepaymentOperationRequest.cs` |
| `CreatePrepaymentRequest` | `Models/CreatePrepaymentRequest.cs` |
| `CreatePrepaymentResponse` | `Models/CreatePrepaymentResponse.cs` |
| `CreatePrepaymentError` | `Errors/CreatePrepaymentError.cs` |
| `CreatePrepaymentErrorResponse` | `Models/AnyOf/CreatePrepaymentErrorResponse.cs` |

### DeductServiceCredit

- **Auth**: `options.BasicAuth`
- **Signature**: `DeductServiceCredit(DeductServiceCreditOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeductServiceCreditError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeductServiceCreditErrorResponse(out DeductServiceCreditErrorResponse)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeductServiceCreditOperationRequest` | `Requests/SubscriptionInvoiceAccount/DeductServiceCreditOperationRequest.cs` |
| `DeductServiceCreditRequest` | `Models/DeductServiceCreditRequest.cs` |
| `DeductServiceCreditError` | `Errors/DeductServiceCreditError.cs` |
| `DeductServiceCreditErrorResponse` | `Models/AnyOf/DeductServiceCreditErrorResponse.cs` |

### IssueServiceCredit

- **Auth**: `options.BasicAuth`
- **Signature**: `IssueServiceCredit(IssueServiceCreditOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `ServiceCredit`
- **Error**: `ApiException<IssueServiceCreditError>` — **Case A (typed)**
- **Error accessors**: `TryGetIssueServiceCreditErrorResponse(out IssueServiceCreditErrorResponse)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `IssueServiceCreditOperationRequest` | `Requests/SubscriptionInvoiceAccount/IssueServiceCreditOperationRequest.cs` |
| `IssueServiceCreditRequest` | `Models/IssueServiceCreditRequest.cs` |
| `ServiceCredit` | `Models/ServiceCredit.cs` |
| `IssueServiceCreditError` | `Errors/IssueServiceCreditError.cs` |
| `IssueServiceCreditErrorResponse` | `Models/AnyOf/IssueServiceCreditErrorResponse.cs` |

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
| `ListPrepaymentsRequest` | `Requests/SubscriptionInvoiceAccount/ListPrepaymentsRequest.cs` |
| `ListPrepaymentsFilter` | `Models/ListPrepaymentsFilter.cs` |
| `PrepaymentsResponse` | `Models/PrepaymentsResponse.cs` |
| `ListPrepaymentsError` | `Errors/ListPrepaymentsError.cs` |

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
| `ListServiceCreditsRequest` | `Requests/SubscriptionInvoiceAccount/ListServiceCreditsRequest.cs` |
| `SortingDirection` | `Models/Enums/SortingDirection.cs` |
| `ListServiceCreditsResponse` | `Models/ListServiceCreditsResponse.cs` |
| `ListServiceCreditsError` | `Errors/ListServiceCreditsError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### ReadAccountBalances

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadAccountBalances(ReadAccountBalancesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `AccountBalances`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReadAccountBalancesRequest` | `Requests/SubscriptionInvoiceAccount/ReadAccountBalancesRequest.cs` |
| `AccountBalances` | `Models/AccountBalances.cs` |

### RefundPrepayment

- **Auth**: `options.BasicAuth`
- **Signature**: `RefundPrepayment(RefundPrepaymentOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `PrepaymentId`
- **Returns**: `PrepaymentResponse`
- **Error**: `ApiException<RefundPrepaymentError>` — **Case A (typed)**
- **Error accessors**: `TryGetRefundPrepaymentBaseErrorsResponse1(out RefundPrepaymentBaseErrorsResponse1)` [400] · `TryGetString(out string)` [404] · `TryGetRefundPrepaymentErrorResponse(out RefundPrepaymentErrorResponse)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RefundPrepaymentOperationRequest` | `Requests/SubscriptionInvoiceAccount/RefundPrepaymentOperationRequest.cs` |
| `RefundPrepaymentRequest` | `Models/RefundPrepaymentRequest.cs` |
| `PrepaymentResponse` | `Models/PrepaymentResponse.cs` |
| `RefundPrepaymentError` | `Errors/RefundPrepaymentError.cs` |
| `RefundPrepaymentBaseErrorsResponse1` | `Models/RefundPrepaymentBaseErrorsResponse1.cs` |
| `RefundPrepaymentErrorResponse` | `Models/AnyOf/RefundPrepaymentErrorResponse.cs` |

