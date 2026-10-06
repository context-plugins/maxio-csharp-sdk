<!-- Generated file — do not edit; regenerated with the SDK. -->

# SubscriptionGroupStatus — operations

Accessor: `client.SubscriptionGroupStatus` · Source: `Api/SubscriptionGroupStatus.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CancelDelayedCancellationForGroup

- **Auth**: `options.BasicAuth`
- **Signature**: `CancelDelayedCancellationForGroup(CancelDelayedCancellationForGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Uid`
- **Returns**: `void` (Task)
- **Error**: `ApiException<CancelDelayedCancellationForGroupError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CancelDelayedCancellationForGroupRequest` | `Requests/SubscriptionGroupStatus/CancelDelayedCancellationForGroupRequest.cs` |
| `CancelDelayedCancellationForGroupError` | `Errors/CancelDelayedCancellationForGroupError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### CancelSubscriptionsInGroup

- **Auth**: `options.BasicAuth`
- **Signature**: `CancelSubscriptionsInGroup(CancelSubscriptionsInGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Uid`
- **Returns**: `void` (Task)
- **Error**: `ApiException<CancelSubscriptionsInGroupError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CancelSubscriptionsInGroupRequest` | `Requests/SubscriptionGroupStatus/CancelSubscriptionsInGroupRequest.cs` |
| `CancelGroupedSubscriptionsRequest` | `Models/CancelGroupedSubscriptionsRequest.cs` |
| `CancelSubscriptionsInGroupError` | `Errors/CancelSubscriptionsInGroupError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### InitiateDelayedCancellationForGroup

- **Auth**: `options.BasicAuth`
- **Signature**: `InitiateDelayedCancellationForGroup(InitiateDelayedCancellationForGroupRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Uid`
- **Returns**: `void` (Task)
- **Error**: `ApiException<InitiateDelayedCancellationForGroupError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `InitiateDelayedCancellationForGroupRequest` | `Requests/SubscriptionGroupStatus/InitiateDelayedCancellationForGroupRequest.cs` |
| `InitiateDelayedCancellationForGroupError` | `Errors/InitiateDelayedCancellationForGroupError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### ReactivateSubscriptionGroup

- **Auth**: `options.BasicAuth`
- **Signature**: `ReactivateSubscriptionGroup(ReactivateSubscriptionGroupOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Uid`
- **Returns**: `ReactivateSubscriptionGroupResponse`
- **Error**: `ApiException<ReactivateSubscriptionGroupError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ReactivateSubscriptionGroupOperationRequest` | `Requests/SubscriptionGroupStatus/ReactivateSubscriptionGroupOperationRequest.cs` |
| `ReactivateSubscriptionGroupRequest` | `Models/ReactivateSubscriptionGroupRequest.cs` |
| `ReactivateSubscriptionGroupResponse` | `Models/ReactivateSubscriptionGroupResponse.cs` |
| `ReactivateSubscriptionGroupError` | `Errors/ReactivateSubscriptionGroupError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

