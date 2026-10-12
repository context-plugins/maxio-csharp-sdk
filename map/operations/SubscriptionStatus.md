<!-- Generated file — do not edit; regenerated with the SDK. -->

# SubscriptionStatus — operations

Accessor: `client.SubscriptionStatus` · Source: `src/Maxio/Api/SubscriptionStatus.cs` · 10 operations

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
| `CancelDelayedCancellationRequest` | `src/Maxio/Requests/SubscriptionStatus/CancelDelayedCancellationRequest.cs` |
| `DelayedCancellationResponse` | `src/Maxio/Models/DelayedCancellationResponse.cs` |
| `CancelDelayedCancellationError` | `src/Maxio/Errors/CancelDelayedCancellationError.cs` |

### CancelDunning

- **Auth**: `options.BasicAuth`
- **Signature**: `CancelDunning(CancelDunningRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `SubscriptionResponse`
- **Error**: `ApiException<CancelDunningError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CancelDunningRequest` | `src/Maxio/Requests/SubscriptionStatus/CancelDunningRequest.cs` |
| `SubscriptionResponse` | `src/Maxio/Models/SubscriptionResponse.cs` |
| `CancelDunningError` | `src/Maxio/Errors/CancelDunningError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### CancelSubscription

- **Auth**: `options.BasicAuth`
- **Signature**: `CancelSubscription(CancelSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `SubscriptionResponse`
- **Error**: `ApiException<CancelSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetCancelSubscriptionErrorResponse(out CancelSubscriptionErrorResponse)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CancelSubscriptionRequest` | `src/Maxio/Requests/SubscriptionStatus/CancelSubscriptionRequest.cs` |
| `CancellationRequest` | `src/Maxio/Models/CancellationRequest.cs` |
| `SubscriptionResponse` | `src/Maxio/Models/SubscriptionResponse.cs` |
| `CancelSubscriptionError` | `src/Maxio/Errors/CancelSubscriptionError.cs` |
| `CancelSubscriptionErrorResponse` | `src/Maxio/Models/AnyOf/CancelSubscriptionErrorResponse.cs` |

### InitiateDelayedCancellation

- **Auth**: `options.BasicAuth`
- **Signature**: `InitiateDelayedCancellation(InitiateDelayedCancellationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `DelayedCancellationResponse`
- **Error**: `ApiException<InitiateDelayedCancellationError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `InitiateDelayedCancellationRequest` | `src/Maxio/Requests/SubscriptionStatus/InitiateDelayedCancellationRequest.cs` |
| `CancellationRequest` | `src/Maxio/Models/CancellationRequest.cs` |
| `DelayedCancellationResponse` | `src/Maxio/Models/DelayedCancellationResponse.cs` |
| `InitiateDelayedCancellationError` | `src/Maxio/Errors/InitiateDelayedCancellationError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### PauseSubscription

- **Auth**: `options.BasicAuth`
- **Signature**: `PauseSubscription(PauseSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `SubscriptionResponse`
- **Error**: `ApiException<PauseSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PauseSubscriptionRequest` | `src/Maxio/Requests/SubscriptionStatus/PauseSubscriptionRequest.cs` |
| `PauseRequest` | `src/Maxio/Models/PauseRequest.cs` |
| `SubscriptionResponse` | `src/Maxio/Models/SubscriptionResponse.cs` |
| `PauseSubscriptionError` | `src/Maxio/Errors/PauseSubscriptionError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### PreviewRenewal

- **Auth**: `options.BasicAuth`
- **Signature**: `PreviewRenewal(PreviewRenewalRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `RenewalPreviewResponse`
- **Error**: `ApiException<PreviewRenewalError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PreviewRenewalRequest` | `src/Maxio/Requests/SubscriptionStatus/PreviewRenewalRequest.cs` |
| `RenewalPreviewRequest` | `src/Maxio/Models/RenewalPreviewRequest.cs` |
| `RenewalPreviewResponse` | `src/Maxio/Models/RenewalPreviewResponse.cs` |
| `PreviewRenewalError` | `src/Maxio/Errors/PreviewRenewalError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### ReactivateSubscription

- **Auth**: `options.BasicAuth`
- **Signature**: `ReactivateSubscription(ReactivateSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `SubscriptionResponse`
- **Error**: `ApiException<ReactivateSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ReactivateSubscriptionOperationRequest` | `src/Maxio/Requests/SubscriptionStatus/ReactivateSubscriptionOperationRequest.cs` |
| `ReactivateSubscriptionRequest` | `src/Maxio/Models/ReactivateSubscriptionRequest.cs` |
| `SubscriptionResponse` | `src/Maxio/Models/SubscriptionResponse.cs` |
| `ReactivateSubscriptionError` | `src/Maxio/Errors/ReactivateSubscriptionError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

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
| `ResumeSubscriptionRequest` | `src/Maxio/Requests/SubscriptionStatus/ResumeSubscriptionRequest.cs` |
| `ResumptionCharge` | `src/Maxio/Models/Enums/ResumptionCharge.cs` |
| `SubscriptionResponse` | `src/Maxio/Models/SubscriptionResponse.cs` |
| `ResumeSubscriptionError` | `src/Maxio/Errors/ResumeSubscriptionError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### RetrySubscription

- **Auth**: `options.BasicAuth`
- **Signature**: `RetrySubscription(RetrySubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `SubscriptionResponse`
- **Error**: `ApiException<RetrySubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RetrySubscriptionRequest` | `src/Maxio/Requests/SubscriptionStatus/RetrySubscriptionRequest.cs` |
| `SubscriptionResponse` | `src/Maxio/Models/SubscriptionResponse.cs` |
| `RetrySubscriptionError` | `src/Maxio/Errors/RetrySubscriptionError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### UpdateAutomaticSubscriptionResumption

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateAutomaticSubscriptionResumption(UpdateAutomaticSubscriptionResumptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `SubscriptionResponse`
- **Error**: `ApiException<UpdateAutomaticSubscriptionResumptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateAutomaticSubscriptionResumptionRequest` | `src/Maxio/Requests/SubscriptionStatus/UpdateAutomaticSubscriptionResumptionRequest.cs` |
| `PauseRequest` | `src/Maxio/Models/PauseRequest.cs` |
| `SubscriptionResponse` | `src/Maxio/Models/SubscriptionResponse.cs` |
| `UpdateAutomaticSubscriptionResumptionError` | `src/Maxio/Errors/UpdateAutomaticSubscriptionResumptionError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

