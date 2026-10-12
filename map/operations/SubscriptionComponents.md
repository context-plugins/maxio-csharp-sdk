<!-- Generated file — do not edit; regenerated with the SDK. -->

# SubscriptionComponents — operations

Accessor: `client.SubscriptionComponents` · Source: `src/Maxio/Api/SubscriptionComponents.cs` · 17 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ActivateEventBasedComponent

- **Auth**: `options.BasicAuth`
- **Signature**: `ActivateEventBasedComponent(ActivateEventBasedComponentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `ComponentId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ActivateEventBasedComponentRequest` | `src/Maxio/Requests/SubscriptionComponents/ActivateEventBasedComponentRequest.cs` |
| `ActivateEventBasedComponent` | `src/Maxio/Models/ActivateEventBasedComponent.cs` |

### AllocateComponent

- **Auth**: `options.BasicAuth`
- **Signature**: `AllocateComponent(AllocateComponentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `ComponentId`
- **Returns**: `AllocationResponse`
- **Error**: `ApiException<AllocateComponentError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AllocateComponentRequest` | `src/Maxio/Requests/SubscriptionComponents/AllocateComponentRequest.cs` |
| `CreateAllocationRequest` | `src/Maxio/Models/CreateAllocationRequest.cs` |
| `AllocationResponse` | `src/Maxio/Models/AllocationResponse.cs` |
| `AllocateComponentError` | `src/Maxio/Errors/AllocateComponentError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### AllocateComponents

- **Auth**: `options.BasicAuth`
- **Signature**: `AllocateComponents(AllocateComponentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `IReadOnlyList<AllocationResponse>`
- **Error**: `ApiException<AllocateComponentsError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AllocateComponentsRequest` | `src/Maxio/Requests/SubscriptionComponents/AllocateComponentsRequest.cs` |
| `AllocateComponents` | `src/Maxio/Models/AllocateComponents.cs` |
| `AllocationResponse` | `src/Maxio/Models/AllocationResponse.cs` |
| `AllocateComponentsError` | `src/Maxio/Errors/AllocateComponentsError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

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
| `BulkRecordEventsRequest` | `src/Maxio/Requests/SubscriptionComponents/BulkRecordEventsRequest.cs` |
| `EbbEvent` | `src/Maxio/Models/EbbEvent.cs` |

### BulkResetSubscriptionComponentsPricePoints

- **Auth**: `options.BasicAuth`
- **Signature**: `BulkResetSubscriptionComponentsPricePoints(BulkResetSubscriptionComponentsPricePointsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `SubscriptionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BulkResetSubscriptionComponentsPricePointsRequest` | `src/Maxio/Requests/SubscriptionComponents/BulkResetSubscriptionComponentsPricePointsRequest.cs` |
| `SubscriptionResponse` | `src/Maxio/Models/SubscriptionResponse.cs` |

### BulkUpdateSubscriptionComponentsPricePoints

- **Auth**: `options.BasicAuth`
- **Signature**: `BulkUpdateSubscriptionComponentsPricePoints(BulkUpdateSubscriptionComponentsPricePointsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `BulkComponentsPricePointAssignment`
- **Error**: `ApiException<BulkUpdateSubscriptionComponentsPricePointsError>` — **Case A (typed)**
- **Error accessors**: `TryGetComponentPricePointError1(out ComponentPricePointError1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `BulkUpdateSubscriptionComponentsPricePointsRequest` | `src/Maxio/Requests/SubscriptionComponents/BulkUpdateSubscriptionComponentsPricePointsRequest.cs` |
| `BulkComponentsPricePointAssignment` | `src/Maxio/Models/BulkComponentsPricePointAssignment.cs` |
| `BulkUpdateSubscriptionComponentsPricePointsError` | `src/Maxio/Errors/BulkUpdateSubscriptionComponentsPricePointsError.cs` |
| `ComponentPricePointError1` | `src/Maxio/Models/ComponentPricePointError1.cs` |

### CreateUsage

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateUsage(CreateUsageOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionIdOrReference`, `ComponentId`
- **Returns**: `UsageResponse`
- **Error**: `ApiException<CreateUsageError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateUsageOperationRequest` | `src/Maxio/Requests/SubscriptionComponents/CreateUsageOperationRequest.cs` |
| `SubscriptionIdOrReference` | `src/Maxio/Models/AnyOf/SubscriptionIdOrReference.cs` |
| `ComponentIdModel` | `src/Maxio/Models/AnyOf/ComponentIdModel.cs` |
| `CreateUsageRequest` | `src/Maxio/Models/CreateUsageRequest.cs` |
| `UsageResponse` | `src/Maxio/Models/UsageResponse.cs` |
| `CreateUsageError` | `src/Maxio/Errors/CreateUsageError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### DeactivateEventBasedComponent

- **Auth**: `options.BasicAuth`
- **Signature**: `DeactivateEventBasedComponent(DeactivateEventBasedComponentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `ComponentId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeactivateEventBasedComponentRequest` | `src/Maxio/Requests/SubscriptionComponents/DeactivateEventBasedComponentRequest.cs` |

### DeletePrepaidUsageAllocation

- **Auth**: `options.BasicAuth`
- **Signature**: `DeletePrepaidUsageAllocation(DeletePrepaidUsageAllocationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `ComponentId`, `AllocationId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeletePrepaidUsageAllocationError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetSubscriptionComponentAllocationError1(out SubscriptionComponentAllocationError1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeletePrepaidUsageAllocationRequest` | `src/Maxio/Requests/SubscriptionComponents/DeletePrepaidUsageAllocationRequest.cs` |
| `CreditSchemeRequest` | `src/Maxio/Models/CreditSchemeRequest.cs` |
| `DeletePrepaidUsageAllocationError` | `src/Maxio/Errors/DeletePrepaidUsageAllocationError.cs` |
| `SubscriptionComponentAllocationError1` | `src/Maxio/Models/SubscriptionComponentAllocationError1.cs` |

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
| `ListAllocationsRequest` | `src/Maxio/Requests/SubscriptionComponents/ListAllocationsRequest.cs` |
| `AllocationResponse` | `src/Maxio/Models/AllocationResponse.cs` |
| `ListAllocationsError` | `src/Maxio/Errors/ListAllocationsError.cs` |
| `ErrorListResponse1` | `src/Maxio/Models/ErrorListResponse1.cs` |

### ListSubscriptionComponents

- **Auth**: `options.BasicAuth`
- **Signature**: `ListSubscriptionComponents(ListSubscriptionComponentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Query params (wire ← C#)**: `date_field` ← `DateField`, `direction` ← `Direction`, `filter` ← `Filter`, `end_date` ← `EndDate`, `end_datetime` ← `EndDatetime`, `price_point_ids` ← `PricePointIds`, `product_family_ids` ← `ProductFamilyIds`, `sort` ← `Sort`, `start_date` ← `StartDate`, `start_datetime` ← `StartDatetime`, `include` ← `Include`, `in_use` ← `InUse`
- **Returns**: `IReadOnlyList<SubscriptionComponentResponse>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListSubscriptionComponentsRequest` | `src/Maxio/Requests/SubscriptionComponents/ListSubscriptionComponentsRequest.cs` |
| `SubscriptionListDateField` | `src/Maxio/Models/Enums/SubscriptionListDateField.cs` |
| `SortingDirection` | `src/Maxio/Models/Enums/SortingDirection.cs` |
| `ListSubscriptionComponentsFilter` | `src/Maxio/Models/ListSubscriptionComponentsFilter.cs` |
| `IncludeNotNull` | `src/Maxio/Models/Enums/IncludeNotNull.cs` |
| `ListSubscriptionComponentsSort` | `src/Maxio/Models/Enums/ListSubscriptionComponentsSort.cs` |
| `ListSubscriptionComponentsInclude` | `src/Maxio/Models/Enums/ListSubscriptionComponentsInclude.cs` |
| `SubscriptionComponentResponse` | `src/Maxio/Models/SubscriptionComponentResponse.cs` |

### ListSubscriptionComponentsForSite

- **Auth**: `options.BasicAuth`
- **Signature**: `ListSubscriptionComponentsForSite(ListSubscriptionComponentsForSiteRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page` ← `Page`, `per_page` ← `PerPage`, `sort` ← `Sort`, `direction` ← `Direction`, `filter` ← `Filter`, `date_field` ← `DateField`, `start_date` ← `StartDate`, `start_datetime` ← `StartDatetime`, `end_date` ← `EndDate`, `end_datetime` ← `EndDatetime`, `subscription_ids` ← `SubscriptionIds`, `price_point_ids` ← `PricePointIds`, `product_family_ids` ← `ProductFamilyIds`, `include` ← `Include`
- **Returns**: `ListSubscriptionComponentsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListSubscriptionComponentsForSiteRequest` | `src/Maxio/Requests/SubscriptionComponents/ListSubscriptionComponentsForSiteRequest.cs` |
| `ListSubscriptionComponentsSort` | `src/Maxio/Models/Enums/ListSubscriptionComponentsSort.cs` |
| `SortingDirection` | `src/Maxio/Models/Enums/SortingDirection.cs` |
| `ListSubscriptionComponentsForSiteFilter` | `src/Maxio/Models/ListSubscriptionComponentsForSiteFilter.cs` |
| `SubscriptionListDateField` | `src/Maxio/Models/Enums/SubscriptionListDateField.cs` |
| `IncludeNotNull` | `src/Maxio/Models/Enums/IncludeNotNull.cs` |
| `ListSubscriptionComponentsInclude` | `src/Maxio/Models/Enums/ListSubscriptionComponentsInclude.cs` |
| `ListSubscriptionComponentsResponse` | `src/Maxio/Models/ListSubscriptionComponentsResponse.cs` |

### ListUsages

- **Auth**: `options.BasicAuth`
- **Signature**: `ListUsages(ListUsagesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionIdOrReference`, `ComponentId`
- **Query params (wire ← C#)**: `since_id` ← `SinceId`, `max_id` ← `MaxId`, `since_date` ← `SinceDate`, `until_date` ← `UntilDate`, `page` ← `Page`, `per_page` ← `PerPage`
- **Returns**: `IReadOnlyList<UsageResponse>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListUsagesRequest` | `src/Maxio/Requests/SubscriptionComponents/ListUsagesRequest.cs` |
| `SubscriptionIdOrReference` | `src/Maxio/Models/AnyOf/SubscriptionIdOrReference.cs` |
| `ComponentIdModel` | `src/Maxio/Models/AnyOf/ComponentIdModel.cs` |
| `UsageResponse` | `src/Maxio/Models/UsageResponse.cs` |

### PreviewAllocations

- **Auth**: `options.BasicAuth`
- **Signature**: `PreviewAllocations(PreviewAllocationsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`
- **Returns**: `AllocationPreviewResponse`
- **Error**: `ApiException<PreviewAllocationsError>` — **Case A (typed)**
- **Error accessors**: `TryGetComponentAllocationError1(out ComponentAllocationError1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PreviewAllocationsOperationRequest` | `src/Maxio/Requests/SubscriptionComponents/PreviewAllocationsOperationRequest.cs` |
| `PreviewAllocationsRequest` | `src/Maxio/Models/PreviewAllocationsRequest.cs` |
| `AllocationPreviewResponse` | `src/Maxio/Models/AllocationPreviewResponse.cs` |
| `PreviewAllocationsError` | `src/Maxio/Errors/PreviewAllocationsError.cs` |
| `ComponentAllocationError1` | `src/Maxio/Models/ComponentAllocationError1.cs` |

### ReadSubscriptionComponent

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadSubscriptionComponent(ReadSubscriptionComponentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `ComponentId`
- **Returns**: `SubscriptionComponentResponse`
- **Error**: `ApiException<ReadSubscriptionComponentError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ReadSubscriptionComponentRequest` | `src/Maxio/Requests/SubscriptionComponents/ReadSubscriptionComponentRequest.cs` |
| `SubscriptionComponentResponse` | `src/Maxio/Models/SubscriptionComponentResponse.cs` |
| `ReadSubscriptionComponentError` | `src/Maxio/Errors/ReadSubscriptionComponentError.cs` |

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
| `RecordEventRequest` | `src/Maxio/Requests/SubscriptionComponents/RecordEventRequest.cs` |
| `EbbEvent` | `src/Maxio/Models/EbbEvent.cs` |

### UpdatePrepaidUsageAllocationExpirationDate

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdatePrepaidUsageAllocationExpirationDate(UpdatePrepaidUsageAllocationExpirationDateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SubscriptionId`, `ComponentId`, `AllocationId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<UpdatePrepaidUsageAllocationExpirationDateError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetSubscriptionComponentAllocationError1(out SubscriptionComponentAllocationError1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdatePrepaidUsageAllocationExpirationDateRequest` | `src/Maxio/Requests/SubscriptionComponents/UpdatePrepaidUsageAllocationExpirationDateRequest.cs` |
| `UpdateAllocationExpirationDate` | `src/Maxio/Models/UpdateAllocationExpirationDate.cs` |
| `UpdatePrepaidUsageAllocationExpirationDateError` | `src/Maxio/Errors/UpdatePrepaidUsageAllocationExpirationDateError.cs` |
| `SubscriptionComponentAllocationError1` | `src/Maxio/Models/SubscriptionComponentAllocationError1.cs` |

