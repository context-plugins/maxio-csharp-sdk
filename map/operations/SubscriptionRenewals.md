<!-- Generated file — do not edit; regenerated with the SDK. -->

# SubscriptionRenewals — operations

Accessor: `client.SubscriptionRenewals` · Source: `Api/SubscriptionRenewals.cs` · 11 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CancelScheduledRenewalConfiguration

- **Auth**: `options.BasicAuth`
- **Signature**: `CancelScheduledRenewalConfiguration(CancelScheduledRenewalConfigurationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `Id`
- **Returns**: `ScheduledRenewalConfigurationResponse`
- **Error**: `ApiException<CancelScheduledRenewalConfigurationError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CancelScheduledRenewalConfigurationRequest` | `Requests/SubscriptionRenewals/CancelScheduledRenewalConfigurationRequest.cs` |
| `ScheduledRenewalConfigurationResponse` | `Models/ScheduledRenewalConfigurationResponse.cs` |
| `CancelScheduledRenewalConfigurationError` | `Errors/CancelScheduledRenewalConfigurationError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### CreateScheduledRenewalConfiguration

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateScheduledRenewalConfiguration(CreateScheduledRenewalConfigurationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `ScheduledRenewalConfigurationResponse`
- **Error**: `ApiException<CreateScheduledRenewalConfigurationError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateScheduledRenewalConfigurationRequest` | `Requests/SubscriptionRenewals/CreateScheduledRenewalConfigurationRequest.cs` |
| `ScheduledRenewalConfigurationRequest` | `Models/ScheduledRenewalConfigurationRequest.cs` |
| `ScheduledRenewalConfigurationResponse` | `Models/ScheduledRenewalConfigurationResponse.cs` |
| `CreateScheduledRenewalConfigurationError` | `Errors/CreateScheduledRenewalConfigurationError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### CreateScheduledRenewalConfigurationItem

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateScheduledRenewalConfigurationItem(CreateScheduledRenewalConfigurationItemRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `ScheduledRenewalsConfigurationId`
- **Returns**: `ScheduledRenewalConfigurationItemResponse`
- **Error**: `ApiException<CreateScheduledRenewalConfigurationItemError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateScheduledRenewalConfigurationItemRequest` | `Requests/SubscriptionRenewals/CreateScheduledRenewalConfigurationItemRequest.cs` |
| `ScheduledRenewalConfigurationItemRequest` | `Models/ScheduledRenewalConfigurationItemRequest.cs` |
| `ScheduledRenewalConfigurationItemResponse` | `Models/ScheduledRenewalConfigurationItemResponse.cs` |
| `CreateScheduledRenewalConfigurationItemError` | `Errors/CreateScheduledRenewalConfigurationItemError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### DeleteScheduledRenewalConfigurationItem

- **Auth**: `options.BasicAuth`
- **Signature**: `DeleteScheduledRenewalConfigurationItem(DeleteScheduledRenewalConfigurationItemRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `ScheduledRenewalsConfigurationId`, `Id`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteScheduledRenewalConfigurationItemError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteScheduledRenewalConfigurationItemRequest` | `Requests/SubscriptionRenewals/DeleteScheduledRenewalConfigurationItemRequest.cs` |
| `DeleteScheduledRenewalConfigurationItemError` | `Errors/DeleteScheduledRenewalConfigurationItemError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### ListScheduledRenewalConfigurations

- **Auth**: `options.BasicAuth`
- **Signature**: `ListScheduledRenewalConfigurations(ListScheduledRenewalConfigurationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Query params (wire ← C#)**: `status` ← `Status`
- **Returns**: `ScheduledRenewalConfigurationsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListScheduledRenewalConfigurationsRequest` | `Requests/SubscriptionRenewals/ListScheduledRenewalConfigurationsRequest.cs` |
| `Status` | `Models/Enums/Status.cs` |
| `ScheduledRenewalConfigurationsResponse` | `Models/ScheduledRenewalConfigurationsResponse.cs` |

### LockInScheduledRenewalImmediately

- **Auth**: `options.BasicAuth`
- **Signature**: `LockInScheduledRenewalImmediately(LockInScheduledRenewalImmediatelyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `Id`
- **Returns**: `ScheduledRenewalConfigurationResponse`
- **Error**: `ApiException<LockInScheduledRenewalImmediatelyError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `LockInScheduledRenewalImmediatelyRequest` | `Requests/SubscriptionRenewals/LockInScheduledRenewalImmediatelyRequest.cs` |
| `ScheduledRenewalConfigurationResponse` | `Models/ScheduledRenewalConfigurationResponse.cs` |
| `LockInScheduledRenewalImmediatelyError` | `Errors/LockInScheduledRenewalImmediatelyError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### ReadScheduledRenewalConfiguration

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadScheduledRenewalConfiguration(ReadScheduledRenewalConfigurationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `Id`
- **Returns**: `ScheduledRenewalConfigurationResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReadScheduledRenewalConfigurationRequest` | `Requests/SubscriptionRenewals/ReadScheduledRenewalConfigurationRequest.cs` |
| `ScheduledRenewalConfigurationResponse` | `Models/ScheduledRenewalConfigurationResponse.cs` |

### ScheduleScheduledRenewalLockIn

- **Auth**: `options.BasicAuth`
- **Signature**: `ScheduleScheduledRenewalLockIn(ScheduleScheduledRenewalLockInRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `Id`
- **Returns**: `ScheduledRenewalConfigurationResponse`
- **Error**: `ApiException<ScheduleScheduledRenewalLockInError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ScheduleScheduledRenewalLockInRequest` | `Requests/SubscriptionRenewals/ScheduleScheduledRenewalLockInRequest.cs` |
| `ScheduledRenewalLockInRequest` | `Models/ScheduledRenewalLockInRequest.cs` |
| `ScheduledRenewalConfigurationResponse` | `Models/ScheduledRenewalConfigurationResponse.cs` |
| `ScheduleScheduledRenewalLockInError` | `Errors/ScheduleScheduledRenewalLockInError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### UnpublishScheduledRenewalConfiguration

- **Auth**: `options.BasicAuth`
- **Signature**: `UnpublishScheduledRenewalConfiguration(UnpublishScheduledRenewalConfigurationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `Id`
- **Returns**: `ScheduledRenewalConfigurationResponse`
- **Error**: `ApiException<UnpublishScheduledRenewalConfigurationError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UnpublishScheduledRenewalConfigurationRequest` | `Requests/SubscriptionRenewals/UnpublishScheduledRenewalConfigurationRequest.cs` |
| `ScheduledRenewalConfigurationResponse` | `Models/ScheduledRenewalConfigurationResponse.cs` |
| `UnpublishScheduledRenewalConfigurationError` | `Errors/UnpublishScheduledRenewalConfigurationError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### UpdateScheduledRenewalConfiguration

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateScheduledRenewalConfiguration(UpdateScheduledRenewalConfigurationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `Id`
- **Returns**: `ScheduledRenewalConfigurationResponse`
- **Error**: `ApiException<UpdateScheduledRenewalConfigurationError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateScheduledRenewalConfigurationRequest` | `Requests/SubscriptionRenewals/UpdateScheduledRenewalConfigurationRequest.cs` |
| `ScheduledRenewalConfigurationRequest` | `Models/ScheduledRenewalConfigurationRequest.cs` |
| `ScheduledRenewalConfigurationResponse` | `Models/ScheduledRenewalConfigurationResponse.cs` |
| `UpdateScheduledRenewalConfigurationError` | `Errors/UpdateScheduledRenewalConfigurationError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### UpdateScheduledRenewalConfigurationItem

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateScheduledRenewalConfigurationItem(UpdateScheduledRenewalConfigurationItemRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `ScheduledRenewalsConfigurationId`, `Id`
- **Returns**: `ScheduledRenewalConfigurationItemResponse`
- **Error**: `ApiException<UpdateScheduledRenewalConfigurationItemError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateScheduledRenewalConfigurationItemRequest` | `Requests/SubscriptionRenewals/UpdateScheduledRenewalConfigurationItemRequest.cs` |
| `ScheduledRenewalUpdateRequest` | `Models/ScheduledRenewalUpdateRequest.cs` |
| `ScheduledRenewalConfigurationItemResponse` | `Models/ScheduledRenewalConfigurationItemResponse.cs` |
| `UpdateScheduledRenewalConfigurationItemError` | `Errors/UpdateScheduledRenewalConfigurationItemError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

