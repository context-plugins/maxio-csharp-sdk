<!-- Generated file — do not edit; regenerated with the SDK. -->

# SubscriptionStatus — operations

Accessor: `client.SubscriptionStatus` · Source: `Api/SubscriptionStatus.cs` · 10 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CancelDelayedCancellation

- **Auth**: `options.BasicAuth`
- **Signature**: `CancelDelayedCancellation(CancelDelayedCancellationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `DelayedCancellationResponse`
- **Error**: `ApiException<CancelDelayedCancellationError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CancelDelayedCancellationRequest` | `Requests/SubscriptionStatus/CancelDelayedCancellationRequest.cs` |
| `DelayedCancellationResponse` | `Models/DelayedCancellationResponse.cs` |
| `CancelDelayedCancellationError` | `Errors/CancelDelayedCancellationError.cs` |

### CancelDunning

- **Auth**: `options.BasicAuth`
- **Signature**: `CancelDunning(CancelDunningRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `SubscriptionResponse`
- **Error**: `ApiException<CancelDunningError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CancelDunningRequest` | `Requests/SubscriptionStatus/CancelDunningRequest.cs` |
| `SubscriptionResponse` | `Models/SubscriptionResponse.cs` |
| `CancelDunningError` | `Errors/CancelDunningError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### CancelSubscription

- **Auth**: `options.BasicAuth`
- **Signature**: `CancelSubscription(CancelSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `SubscriptionResponse`
- **Error**: `ApiException<CancelSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetCancelSubscriptionErrorResponse(out CancelSubscriptionErrorResponse)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CancelSubscriptionRequest` | `Requests/SubscriptionStatus/CancelSubscriptionRequest.cs` |
| `CancellationRequest` | `Models/CancellationRequest.cs` |
| `SubscriptionResponse` | `Models/SubscriptionResponse.cs` |
| `CancelSubscriptionError` | `Errors/CancelSubscriptionError.cs` |
| `CancelSubscriptionErrorResponse` | `Models/AnyOf/CancelSubscriptionErrorResponse.cs` |

### InitiateDelayedCancellation

- **Auth**: `options.BasicAuth`
- **Signature**: `InitiateDelayedCancellation(InitiateDelayedCancellationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `DelayedCancellationResponse`
- **Error**: `ApiException<InitiateDelayedCancellationError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `InitiateDelayedCancellationRequest` | `Requests/SubscriptionStatus/InitiateDelayedCancellationRequest.cs` |
| `CancellationRequest` | `Models/CancellationRequest.cs` |
| `DelayedCancellationResponse` | `Models/DelayedCancellationResponse.cs` |
| `InitiateDelayedCancellationError` | `Errors/InitiateDelayedCancellationError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### PauseSubscription

- **Auth**: `options.BasicAuth`
- **Signature**: `PauseSubscription(PauseSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `SubscriptionResponse`
- **Error**: `ApiException<PauseSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PauseSubscriptionRequest` | `Requests/SubscriptionStatus/PauseSubscriptionRequest.cs` |
| `PauseRequest` | `Models/PauseRequest.cs` |
| `SubscriptionResponse` | `Models/SubscriptionResponse.cs` |
| `PauseSubscriptionError` | `Errors/PauseSubscriptionError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### PreviewRenewal

- **Auth**: `options.BasicAuth`
- **Signature**: `PreviewRenewal(PreviewRenewalRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `RenewalPreviewResponse`
- **Error**: `ApiException<PreviewRenewalError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PreviewRenewalRequest` | `Requests/SubscriptionStatus/PreviewRenewalRequest.cs` |
| `RenewalPreviewRequest` | `Models/RenewalPreviewRequest.cs` |
| `RenewalPreviewResponse` | `Models/RenewalPreviewResponse.cs` |
| `PreviewRenewalError` | `Errors/PreviewRenewalError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### ReactivateSubscription

- **Auth**: `options.BasicAuth`
- **Signature**: `ReactivateSubscription(ReactivateSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `SubscriptionResponse`
- **Error**: `ApiException<ReactivateSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ReactivateSubscriptionOperationRequest` | `Requests/SubscriptionStatus/ReactivateSubscriptionOperationRequest.cs` |
| `ReactivateSubscriptionRequest` | `Models/ReactivateSubscriptionRequest.cs` |
| `SubscriptionResponse` | `Models/SubscriptionResponse.cs` |
| `ReactivateSubscriptionError` | `Errors/ReactivateSubscriptionError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### ResumeSubscription

- **Auth**: `options.BasicAuth`
- **Signature**: `ResumeSubscription(ResumeSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Query params (wire ← C#)**: `calendar_billing['resumption_charge']` ← `CalendarBillingResumptionCharge`
- **Returns**: `SubscriptionResponse`
- **Error**: `ApiException<ResumeSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ResumeSubscriptionRequest` | `Requests/SubscriptionStatus/ResumeSubscriptionRequest.cs` |
| `ResumptionCharge` | `Models/Enums/ResumptionCharge.cs` |
| `SubscriptionResponse` | `Models/SubscriptionResponse.cs` |
| `ResumeSubscriptionError` | `Errors/ResumeSubscriptionError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### RetrySubscription

- **Auth**: `options.BasicAuth`
- **Signature**: `RetrySubscription(RetrySubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `SubscriptionResponse`
- **Error**: `ApiException<RetrySubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RetrySubscriptionRequest` | `Requests/SubscriptionStatus/RetrySubscriptionRequest.cs` |
| `SubscriptionResponse` | `Models/SubscriptionResponse.cs` |
| `RetrySubscriptionError` | `Errors/RetrySubscriptionError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### UpdateAutomaticSubscriptionResumption

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateAutomaticSubscriptionResumption(UpdateAutomaticSubscriptionResumptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `SubscriptionResponse`
- **Error**: `ApiException<UpdateAutomaticSubscriptionResumptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateAutomaticSubscriptionResumptionRequest` | `Requests/SubscriptionStatus/UpdateAutomaticSubscriptionResumptionRequest.cs` |
| `PauseRequest` | `Models/PauseRequest.cs` |
| `SubscriptionResponse` | `Models/SubscriptionResponse.cs` |
| `UpdateAutomaticSubscriptionResumptionError` | `Errors/UpdateAutomaticSubscriptionResumptionError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

