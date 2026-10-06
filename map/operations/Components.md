<!-- Generated file — do not edit; regenerated with the SDK. -->

# Components — operations

Accessor: `client.Components` · Source: `Api/Components.cs` · 12 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ArchiveComponent

- **Auth**: `options.BasicAuth`
- **Signature**: `ArchiveComponent(ArchiveComponentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductFamilyId`, `ComponentId`
- **Returns**: `Component`
- **Error**: `ApiException<ArchiveComponentError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ArchiveComponentRequest` | `Requests/Components/ArchiveComponentRequest.cs` |
| `Component` | `Models/Component.cs` |
| `ArchiveComponentError` | `Errors/ArchiveComponentError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### CreateEventBasedComponent

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateEventBasedComponent(CreateEventBasedComponentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductFamilyId`
- **Returns**: `ComponentResponse`
- **Error**: `ApiException<CreateEventBasedComponentError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateEventBasedComponentRequest` | `Requests/Components/CreateEventBasedComponentRequest.cs` |
| `CreateEbbComponent` | `Models/CreateEbbComponent.cs` |
| `ComponentResponse` | `Models/ComponentResponse.cs` |
| `CreateEventBasedComponentError` | `Errors/CreateEventBasedComponentError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### CreateMeteredComponent

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateMeteredComponent(CreateMeteredComponentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductFamilyId`
- **Returns**: `ComponentResponse`
- **Error**: `ApiException<CreateMeteredComponentError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateMeteredComponentRequest` | `Requests/Components/CreateMeteredComponentRequest.cs` |
| `CreateMeteredComponent` | `Models/CreateMeteredComponent.cs` |
| `ComponentResponse` | `Models/ComponentResponse.cs` |
| `CreateMeteredComponentError` | `Errors/CreateMeteredComponentError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### CreateOnOffComponent

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateOnOffComponent(CreateOnOffComponentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductFamilyId`
- **Returns**: `ComponentResponse`
- **Error**: `ApiException<CreateOnOffComponentError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateOnOffComponentRequest` | `Requests/Components/CreateOnOffComponentRequest.cs` |
| `CreateOnOffComponent` | `Models/CreateOnOffComponent.cs` |
| `ComponentResponse` | `Models/ComponentResponse.cs` |
| `CreateOnOffComponentError` | `Errors/CreateOnOffComponentError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### CreatePrepaidUsageComponent

- **Auth**: `options.BasicAuth`
- **Signature**: `CreatePrepaidUsageComponent(CreatePrepaidUsageComponentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductFamilyId`
- **Returns**: `ComponentResponse`
- **Error**: `ApiException<CreatePrepaidUsageComponentError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreatePrepaidUsageComponentRequest` | `Requests/Components/CreatePrepaidUsageComponentRequest.cs` |
| `CreatePrepaidComponent` | `Models/CreatePrepaidComponent.cs` |
| `ComponentResponse` | `Models/ComponentResponse.cs` |
| `CreatePrepaidUsageComponentError` | `Errors/CreatePrepaidUsageComponentError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### CreateQuantityBasedComponent

- **Auth**: `options.BasicAuth`
- **Signature**: `CreateQuantityBasedComponent(CreateQuantityBasedComponentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductFamilyId`
- **Returns**: `ComponentResponse`
- **Error**: `ApiException<CreateQuantityBasedComponentError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404] · `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateQuantityBasedComponentRequest` | `Requests/Components/CreateQuantityBasedComponentRequest.cs` |
| `CreateQuantityBasedComponent` | `Models/CreateQuantityBasedComponent.cs` |
| `ComponentResponse` | `Models/ComponentResponse.cs` |
| `CreateQuantityBasedComponentError` | `Errors/CreateQuantityBasedComponentError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### FindComponent

- **Auth**: `options.BasicAuth`
- **Signature**: `FindComponent(FindComponentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Handle`
- **Query params (wire ← C#)**: `handle` ← `Handle`
- **Returns**: `ComponentResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FindComponentRequest` | `Requests/Components/FindComponentRequest.cs` |
| `ComponentResponse` | `Models/ComponentResponse.cs` |

### ListComponents

- **Auth**: `options.BasicAuth`
- **Signature**: `ListComponents(ListComponentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `date_field` ← `DateField`, `start_date` ← `StartDate`, `end_date` ← `EndDate`, `start_datetime` ← `StartDatetime`, `end_datetime` ← `EndDatetime`, `include_archived` ← `IncludeArchived`, `page` ← `Page`, `per_page` ← `PerPage`, `filter` ← `Filter`
- **Returns**: `IReadOnlyList<ComponentResponse>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListComponentsRequest` | `Requests/Components/ListComponentsRequest.cs` |
| `BasicDateField` | `Models/Enums/BasicDateField.cs` |
| `ListComponentsFilter` | `Models/ListComponentsFilter.cs` |
| `ComponentResponse` | `Models/ComponentResponse.cs` |

### ListComponentsForProductFamily

- **Auth**: `options.BasicAuth`
- **Signature**: `ListComponentsForProductFamily(ListComponentsForProductFamilyRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductFamilyId`
- **Query params (wire ← C#)**: `include_archived` ← `IncludeArchived`, `page` ← `Page`, `per_page` ← `PerPage`, `filter` ← `Filter`, `date_field` ← `DateField`, `end_date` ← `EndDate`, `end_datetime` ← `EndDatetime`, `start_date` ← `StartDate`, `start_datetime` ← `StartDatetime`
- **Returns**: `IReadOnlyList<ComponentResponse>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ListComponentsForProductFamilyRequest` | `Requests/Components/ListComponentsForProductFamilyRequest.cs` |
| `ListComponentsFilter` | `Models/ListComponentsFilter.cs` |
| `BasicDateField` | `Models/Enums/BasicDateField.cs` |
| `ComponentResponse` | `Models/ComponentResponse.cs` |

### ReadComponent

- **Auth**: `options.BasicAuth`
- **Signature**: `ReadComponent(ReadComponentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductFamilyId`, `ComponentId`
- **Query params (wire ← C#)**: `include_features` ← `IncludeFeatures`
- **Returns**: `ComponentResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReadComponentRequest` | `Requests/Components/ReadComponentRequest.cs` |
| `ComponentResponse` | `Models/ComponentResponse.cs` |

### UpdateComponent

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateComponent(UpdateComponentOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ComponentId`
- **Returns**: `ComponentResponse`
- **Error**: `ApiException<UpdateComponentError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateComponentOperationRequest` | `Requests/Components/UpdateComponentOperationRequest.cs` |
| `UpdateComponentRequest` | `Models/UpdateComponentRequest.cs` |
| `ComponentResponse` | `Models/ComponentResponse.cs` |
| `UpdateComponentError` | `Errors/UpdateComponentError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

### UpdateProductFamilyComponent

- **Auth**: `options.BasicAuth`
- **Signature**: `UpdateProductFamilyComponent(UpdateProductFamilyComponentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ProductFamilyId`, `ComponentId`
- **Returns**: `ComponentResponse`
- **Error**: `ApiException<UpdateProductFamilyComponentError>` — **Case A (typed)**
- **Error accessors**: `TryGetErrorListResponse1(out ErrorListResponse1)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateProductFamilyComponentRequest` | `Requests/Components/UpdateProductFamilyComponentRequest.cs` |
| `UpdateComponentRequest` | `Models/UpdateComponentRequest.cs` |
| `ComponentResponse` | `Models/ComponentResponse.cs` |
| `UpdateProductFamilyComponentError` | `Errors/UpdateProductFamilyComponentError.cs` |
| `ErrorListResponse1` | `Models/ErrorListResponse1.cs` |

