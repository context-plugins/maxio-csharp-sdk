<!-- Generated file — do not edit; regenerated with the SDK. -->

# SubscriptionComponents — operations

Accessor: `client.SubscriptionComponents` · Source: `Api/SubscriptionComponents.cs` · 17 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ActivateEventBasedComponent

- **Auth**: `options.BasicAuth`
- **Signature**: `ActivateEventBasedComponent(ActivateEventBasedComponentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `ComponentId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ActivateEventBasedComponentRequest` | `Requests/SubscriptionComponents/ActivateEventBasedComponentRequest.cs` |
| `ActivateEventBasedComponent` | `Models/ActivateEventBasedComponent.cs` |

### AllocateComponent

- **Auth**: `options.BasicAuth`
- **Signature**: `AllocateComponent(AllocateComponentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `ComponentId`
- **Returns**: `AllocationResponse`
- **Error**: `ApiException<AllocateComponentError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AllocateComponentRequest` | `Requests/SubscriptionComponents/AllocateComponentRequest.cs` |
| `CreateAllocationRequest` | `Models/CreateAllocationRequest.cs` |
| `AllocationResponse` | `Models/AllocationResponse.cs` |
| `AllocateComponentError` | `Errors/AllocateComponentError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### AllocateComponents

- **Auth**: `options.BasicAuth`
- **Signature**: `AllocateComponents(AllocateComponentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `IReadOnlyList<AllocationResponse>`
- **Error**: `ApiException<AllocateComponentsError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AllocateComponentsRequest` | `Requests/SubscriptionComponents/AllocateComponentsRequest.cs` |
| `AllocateComponents` | `Models/AllocateComponents.cs` |
| `AllocationResponse` | `Models/AllocationResponse.cs` |
| `AllocateComponentsError` | `Errors/AllocateComponentsError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### BulkRecordEvents

- **Server group**: `Ebb`
- **Auth**: `options.BasicAuth`
- **Signature**: `BulkRecordEvents(BulkRecordEventsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ApiHandle`
- **Query params (wire ← C#)**: `store_uid` ← `StoreUid`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkRecordEventsRequest` | `Requests/SubscriptionComponents/BulkRecordEventsRequest.cs` |
| `EbbEvent` | `Models/EbbEvent.cs` |

### BulkResetSubscriptionComponentsPricePoints

- **Auth**: `options.BasicAuth`
- **Signature**: `BulkResetSubscriptionComponentsPricePoints(BulkResetSubscriptionComponentsPricePointsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `SubscriptionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkResetSubscriptionComponentsPricePointsRequest` | `Requests/SubscriptionComponents/BulkResetSubscriptionComponentsPricePointsRequest.cs` |
| `SubscriptionResponse` | `Models/SubscriptionResponse.cs` |

### BulkUpdateSubscriptionComponentsPricePoints

- **Auth**: `options.BasicAuth`
- **Signature**: `BulkUpdateSubscriptionComponentsPricePoints(BulkUpdateSubscriptionComponentsPricePointsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `BulkComponentsPricePointAssignment`
- **Error**: `ApiException<BulkUpdateSubscriptionComponentsPricePointsError>` — **Case A (typed)**
- **Error accessors**: `TryGetComponentPricePointError1(out ComponentPricePointError1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `BulkUpdateSubscriptionComponentsPricePointsRequest` | `Requests/SubscriptionComponents/BulkUpdateSubscriptionComponentsPricePointsRequest.cs` |
| `BulkComponentsPricePointAssignment` | `Models/BulkComponentsPricePointAssignment.cs` |
| `BulkUpdateSubscriptionComponentsPricePointsError` | `Errors/BulkUpdateSubscriptionComponentsPricePointsError.cs` |
| `ComponentPricePointError1` | `Models/ComponentPricePointError1.cs` |

### CreateUsage

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateUsage(CreateUsageOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionIdOrReference`, `ComponentId`
- **Returns**: `UsageResponse`
- **Error**: `ApiException<CreateUsageError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateUsageOperationRequest` | `Requests/SubscriptionComponents/CreateUsageOperationRequest.cs` |
| `SubscriptionIdOrReference` | `Models/AnyOf/SubscriptionIdOrReference.cs` |
| `ComponentIdModel` | `Models/AnyOf/ComponentIdModel.cs` |
| `CreateUsageRequest` | `Models/CreateUsageRequest.cs` |
| `UsageResponse` | `Models/UsageResponse.cs` |
| `CreateUsageError` | `Errors/CreateUsageError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### DeactivateEventBasedComponent

- **Auth**: `options.BasicAuth`
- **Signature**: `DeactivateEventBasedComponent(DeactivateEventBasedComponentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `ComponentId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeactivateEventBasedComponentRequest` | `Requests/SubscriptionComponents/DeactivateEventBasedComponentRequest.cs` |

### DeletePrepaidUsageAllocation

- **Auth**: `options.BasicAuth`
- **Signature**: `DeletePrepaidUsageAllocation(DeletePrepaidUsageAllocationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `ComponentId`, `AllocationId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeletePrepaidUsageAllocationError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetSubscriptionComponentAllocationError1(out SubscriptionComponentAllocationError1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeletePrepaidUsageAllocationRequest` | `Requests/SubscriptionComponents/DeletePrepaidUsageAllocationRequest.cs` |
| `CreditSchemeRequest` | `Models/CreditSchemeRequest.cs` |
| `DeletePrepaidUsageAllocationError` | `Errors/DeletePrepaidUsageAllocationError.cs` |
| `SubscriptionComponentAllocationError1` | `Models/SubscriptionComponentAllocationError1.cs` |

### ListAllocations

- **Auth**: `options.BasicAuth`
- **Signature**: `ListAllocations(ListAllocationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `ComponentId`
- **Query params (wire ← C#)**: `page` ← `Page`
- **Returns**: `IReadOnlyList<AllocationResponse>`
- **Error**: `ApiException<ListAllocationsError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListAllocationsRequest` | `Requests/SubscriptionComponents/ListAllocationsRequest.cs` |
| `AllocationResponse` | `Models/AllocationResponse.cs` |
| `ListAllocationsError` | `Errors/ListAllocationsError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### ListSubscriptionComponents

- **Auth**: `options.BasicAuth`
- **Signature**: `ListSubscriptionComponents(ListSubscriptionComponentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Query params (wire ← C#)**: `date_field` ← `DateField`, `direction` ← `Direction`, `filter` ← `Filter`, `end_date` ← `EndDate`, `end_datetime` ← `EndDatetime`, `price_point_ids` ← `PricePointIds`, `product_family_ids` ← `ProductFamilyIds`, `sort` ← `Sort`, `start_date` ← `StartDate`, `start_datetime` ← `StartDatetime`, `include` ← `Include`, `in_use` ← `InUse`
- **Returns**: `IReadOnlyList<SubscriptionComponentResponse>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListSubscriptionComponentsRequest` | `Requests/SubscriptionComponents/ListSubscriptionComponentsRequest.cs` |
| `SubscriptionListDateField` | `Models/Enums/SubscriptionListDateField.cs` |
| `SortingDirection` | `Models/Enums/SortingDirection.cs` |
| `ListSubscriptionComponentsFilter` | `Models/ListSubscriptionComponentsFilter.cs` |
| `IncludeNotNull` | `Models/Enums/IncludeNotNull.cs` |
| `ListSubscriptionComponentsSort` | `Models/Enums/ListSubscriptionComponentsSort.cs` |
| `ListSubscriptionComponentsInclude` | `Models/Enums/ListSubscriptionComponentsInclude.cs` |
| `SubscriptionComponentResponse` | `Models/SubscriptionComponentResponse.cs` |

### ListSubscriptionComponentsForSite

- **Auth**: `options.BasicAuth`
- **Signature**: `ListSubscriptionComponentsForSite(ListSubscriptionComponentsForSiteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page` ← `Page`, `per_page` ← `PerPage`, `sort` ← `Sort`, `direction` ← `Direction`, `filter` ← `Filter`, `date_field` ← `DateField`, `start_date` ← `StartDate`, `start_datetime` ← `StartDatetime`, `end_date` ← `EndDate`, `end_datetime` ← `EndDatetime`, `subscription_ids` ← `SubscriptionIds`, `price_point_ids` ← `PricePointIds`, `product_family_ids` ← `ProductFamilyIds`, `include` ← `Include`
- **Returns**: `ListSubscriptionComponentsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListSubscriptionComponentsForSiteRequest` | `Requests/SubscriptionComponents/ListSubscriptionComponentsForSiteRequest.cs` |
| `ListSubscriptionComponentsSort` | `Models/Enums/ListSubscriptionComponentsSort.cs` |
| `SortingDirection` | `Models/Enums/SortingDirection.cs` |
| `ListSubscriptionComponentsForSiteFilter` | `Models/ListSubscriptionComponentsForSiteFilter.cs` |
| `SubscriptionListDateField` | `Models/Enums/SubscriptionListDateField.cs` |
| `IncludeNotNull` | `Models/Enums/IncludeNotNull.cs` |
| `ListSubscriptionComponentsInclude` | `Models/Enums/ListSubscriptionComponentsInclude.cs` |
| `ListSubscriptionComponentsResponse` | `Models/ListSubscriptionComponentsResponse.cs` |

### ListUsages

- **Auth**: `options.BasicAuth`
- **Signature**: `ListUsages(ListUsagesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionIdOrReference`, `ComponentId`
- **Query params (wire ← C#)**: `since_id` ← `SinceId`, `max_id` ← `MaxId`, `since_date` ← `SinceDate`, `until_date` ← `UntilDate`, `page` ← `Page`, `per_page` ← `PerPage`
- **Returns**: `IReadOnlyList<UsageResponse>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListUsagesRequest` | `Requests/SubscriptionComponents/ListUsagesRequest.cs` |
| `SubscriptionIdOrReference` | `Models/AnyOf/SubscriptionIdOrReference.cs` |
| `ComponentIdModel` | `Models/AnyOf/ComponentIdModel.cs` |
| `UsageResponse` | `Models/UsageResponse.cs` |

### PreviewAllocations

- **Auth**: `options.BasicAuth`
- **Signature**: `PreviewAllocations(PreviewAllocationsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `AllocationPreviewResponse`
- **Error**: `ApiException<PreviewAllocationsError>` — **Case A (typed)**
- **Error accessors**: `TryGetComponentAllocationError1(out ComponentAllocationError1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PreviewAllocationsOperationRequest` | `Requests/SubscriptionComponents/PreviewAllocationsOperationRequest.cs` |
| `PreviewAllocationsRequest` | `Models/PreviewAllocationsRequest.cs` |
| `AllocationPreviewResponse` | `Models/AllocationPreviewResponse.cs` |
| `PreviewAllocationsError` | `Errors/PreviewAllocationsError.cs` |
| `ComponentAllocationError1` | `Models/ComponentAllocationError1.cs` |

### ReadSubscriptionComponent

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadSubscriptionComponent(ReadSubscriptionComponentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `ComponentId`
- **Returns**: `SubscriptionComponentResponse`
- **Error**: `ApiException<ReadSubscriptionComponentError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ReadSubscriptionComponentRequest` | `Requests/SubscriptionComponents/ReadSubscriptionComponentRequest.cs` |
| `SubscriptionComponentResponse` | `Models/SubscriptionComponentResponse.cs` |
| `ReadSubscriptionComponentError` | `Errors/ReadSubscriptionComponentError.cs` |

### RecordEvent

- **Server group**: `Ebb`
- **Auth**: `options.BasicAuth`
- **Signature**: `RecordEvent(RecordEventRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ApiHandle`
- **Query params (wire ← C#)**: `store_uid` ← `StoreUid`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RecordEventRequest` | `Requests/SubscriptionComponents/RecordEventRequest.cs` |
| `EbbEvent` | `Models/EbbEvent.cs` |

### UpdatePrepaidUsageAllocationExpirationDate

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdatePrepaidUsageAllocationExpirationDate(UpdatePrepaidUsageAllocationExpirationDateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `ComponentId`, `AllocationId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<UpdatePrepaidUsageAllocationExpirationDateError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetSubscriptionComponentAllocationError1(out SubscriptionComponentAllocationError1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdatePrepaidUsageAllocationExpirationDateRequest` | `Requests/SubscriptionComponents/UpdatePrepaidUsageAllocationExpirationDateRequest.cs` |
| `UpdateAllocationExpirationDate` | `Models/UpdateAllocationExpirationDate.cs` |
| `UpdatePrepaidUsageAllocationExpirationDateError` | `Errors/UpdatePrepaidUsageAllocationExpirationDateError.cs` |
| `SubscriptionComponentAllocationError1` | `Models/SubscriptionComponentAllocationError1.cs` |

